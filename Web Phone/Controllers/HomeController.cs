﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using Web_Phone.Models;
using System.IO;

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using Website.Models;
using System.IO;*/

namespace Web_Phone.Controllers
{
	public class HomeController : Controller
	{
		webphoneEntities db = new webphoneEntities();
		// GET: Home
		//登入畫面
		public ActionResult Login()
		{
			ViewBag.name = TempData["name"];
			ViewBag.index = TempData["index"];
			ViewBag.post1 = TempData["post1"];
			ViewBag.post2 = TempData["post2"];
			TempData.Keep();
			return View();
		}
		[HttpPost]
		public ActionResult Login(Sign_in Sign_in)
		{
			// 依帳密取得會員並指定給meMain_sign_in_successber
			/*
			var member = db.sign_in
				.Where(m => m.usr_index == usr_index && m.usr_name == usr_name && m.usr_key == usr_key)
				.FirstOrDefault();
			//若member為null，表示會員未註冊
				if (member == null)
				{
					ViewBag.Message = "帳密錯誤，登入失敗";
					return View();
				}*/
			string index = Sign_in.usr_index;
			string key = Sign_in.usr_key;
			string name = Sign_in.usr_name;
			string post1 = "";
			string post2 = "";
			Sign_in_db sign_db = new Sign_in_db();
			List<Sign_in> sign = new List<Sign_in>();
			sign = sign_db.sign_in_select(index, key, name);
			foreach (Sign_in sig in sign)
			{
				if (sig.post1 != "")
					post1 = sig.post1;
				if (sig.post2 != "")
					post2 = sig.post2;
			}

			TempData["post1"] = post1;
			TempData["post2"] = post2;
			TempData["index"] = index;
			TempData["name"] = name;
			return RedirectToAction("Login");
		}

		//Get:Index/Logout
		public ActionResult Logout()
		{
			Session.Clear();  //清除Session變數資料
			return RedirectToAction("Login");
		}
		public ActionResult Logintest()
		{
			return View();
		}
		/*	[HttpPost]
			public ActionResult Logintest(Sign_in_db Sin_in_db)
			{

			}*/
		//忘記帳密
		public ActionResult Forgetpassword()
		{
			return View();
		}
		//尚未註冊
		public ActionResult Notregistered()
		{
			return View();
		}
		//家屬手冊
		public ActionResult Familyobligations()
		{
			return View();
		}
		//家屬主頁面
		public ActionResult Familindex()
		{
			return View();
		}
		/*	[HttpPost]
			public ActionResult Familindex(home_write_db home_write_db)
			{
				home_write_db dbmanager = new home_write_db();
				try
				{
				//	dbmanager.home_write_select(home_write_db);
				}
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
				}
				return View();
			}*/

		//照顧專欄
		public ActionResult Carecolumn()
		{
			return View();
		}

		//照顧專欄-照顧技巧
		public ActionResult Careskills()
		{
			return View();
		}

		//照顧專欄-打氣區
		public ActionResult Cheeruparea()
		{
			return View();
		}

		//照顧專欄-課程資訊
		public ActionResult CourseInformation()
		{
			return View();
		}

		//守護紀錄
		public ActionResult Guardrecord()
		{
			return View();
		}

		//每次守護紀錄
		public ActionResult Every_guardian()
		{
			return View();
		}
		/*	[HttpPost]
			public ActionResult Every_guardian(Guarding_records_every Guarding_records_every)
			{
				Guarding_records_every dbmanager = new Guarding_records_every();
				try
				{
		//			dbmanager.Guarding_records_every_select(Guarding_records_every);
				}
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
				}
				return View();
			}
		*/

		//每月守護紀錄
		public ActionResult Guardian_of_the_month()
		{
			return View();
		}
		/*	[HttpPost]
			public ActionResult Guardian_of_the_month1(Guarding_records_every_moon Guarding_records_every_moon)
			{
				Guarding_records_every_moon dbmanager = new Guarding_records_every_moon();
				try
				{
		//			dbmanager.Guarding_records_every_moon_select(Guarding_records_every_moon);
				}
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
				}
				return View();
			}*/

		//照顧日誌
		public ActionResult Daily_care_records()
		{
			return View();
		}
		/*	[HttpPost]
			public ActionResult Daily_care_records(care_log_db care_log_db)
			{
				care_log_db dbmanager = new care_log_db();
				try
				{
		//			dbmanager.abuse_db_insert(care_log_db);
				}
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
				}
				return View();
			}
		*/

		//家屬照顧紀錄
		public ActionResult Family_care_records()
		{
			return View();
		}
		/*	[HttpPost]
			public ActionResult Family_care_log(Guarding_records_every Guarding_records_every)
			{
				Guarding_records_every dbmanager = new Guarding_records_every();
				try
				{
			//		dbmanager.Guarding_records_every_select(Guarding_records_every);
				}
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
				}
				return View();
			}
		*/

		//家屬照顧紀錄-有去就醫時
		public ActionResult When_go_to_the_doctor()
		{
			return View();
		}
		/*	[HttpPost]
			public ActionResult When_go_to_the_doctor(family_attend_db family_attend_db)
			{
				family_attend_db dbmanager = new family_attend_db();
				try
				{
		//			dbmanager.family_attend_db_insert(family_attend_db);
				}
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
				}
				return View();
			}*/


		//有話要說
		public ActionResult Have_something_to_say()
		{
			return View();
		}
		[HttpPost]
		public ActionResult Have_something_to_say(Tell tell)
		{
			Tell_db tell_db = new Tell_db();
			try
			{
				tell_db.Tell_insert(tell);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.ToString());
			}
			return View();
		}


		//給予回饋
		public ActionResult Give_feedback()
		{
			return View();
		}
		/*	[HttpPost]
			public ActionResult Give_feedback(reply_db reply_db)
			{
				reply_db dbmanager = new reply_db();
				try
				{
		//			dbmanager.reply_db_insert(reply_db);
				}
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
				}
				return View();
			}

	*/




		//照服員-工作手冊
		public ActionResult Workbook()
		{
			return View();
		}

		//照服員-緊急意外流程
		public ActionResult Emergency_accident_handling_process()
		{
			ViewBag.name = TempData["name"];
			ViewBag.index = TempData["index"];
			TempData.Keep();
			return View();
		}

		//照服員網路打卡頁面
		public ActionResult Home_attendant_main_sign_in_page()
		{
			ViewBag.name = TempData["name"];
			ViewBag.index = TempData["index"];
			TempData.Keep();
			return View();
		}
		/*	[HttpPost]
			public ActionResult Home_attendant_main_sign_in_page(worker_arrive_db worker_arrive_db)
			{
				worker_arrive_db dbmanager = new worker_arrive_db();
				try
				{
					//		dbmanager.worker_arrive_db_insert(worker_arrive_db);
				}
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
				}
				return View();
			}
		*/

		//照服員-上班打卡登入
		public ActionResult Main_sign_in_success()
		{
			ViewBag.name = TempData["name"];
			ViewBag.index = TempData["index"];
			TempData.Keep();
			return View();
		}
		[HttpPost]
		public ActionResult Main_sign_in_success(Daycheck daycheck)
		{
			Daycheck_db daycheck_db = new Daycheck_db();
			worker_arrive_db worker_db = new worker_arrive_db();
			
				worker_db.worker_arrive_insert(daycheck.usr_name);
				daycheck_db.NewDaycheck(daycheck);
			
			return RedirectToAction("Select_case_schedule");
		}

		//照服員-再次進入
		public ActionResult Again_into()
		{
			ViewBag.name = TempData["name"];
			ViewBag.index = TempData["index"];
			TempData.Keep();
			return View();
		}

		//照服員-下班打卡登出
		public ActionResult Sign_out()
		{
			ViewBag.ii = TempData["name"];
			TempData.Keep();
			return View();
		}
			[HttpPost]
			public ActionResult Sign_out(worker_arrive worker_arrive)
			{
				worker_arrive_db dbmanager = new worker_arrive_db();
				try
				{
					dbmanager.worker_arrive_update(TempData["name"] as string);
				}
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
				}
				return RedirectToAction("Login");
			}
		

		//照服員-個案班表
		public ActionResult Select_case_schedule()
		{
			string name = TempData["name"] as string;
			Roster_db roster_Db = new Roster_db();
			List<Roster> rosters = roster_Db.Roster_select(name);
			ViewBag.name = name;
			ViewBag.index = TempData["index"];
			ViewBag.roser = rosters;
			TempData.Keep();
			return View();
		}
		/*	[HttpPost]
			public ActionResult Select_case_schedule(Roster_db Roster_db)
			{
				Roster_db dbmanager = new Roster_db();
				try
				{
		//			dbmanager.Roster_db_select(Roster_db);
				}
				catch (Exception e)
				{	
					Console.WriteLine(e.ToString());
				}
				return View();
			}
		*/

		//照服員主頁面
		public ActionResult Home_attendant_index()
		{
			ViewBag.name = TempData["name"];
			ViewBag.index = TempData["index"];
			TempData.Keep();
			return View();
		}

		//家屬照顧紀錄-照服員
		public ActionResult Family_care_record_Home_attendant()
		{
			ViewBag.name = TempData["name"];
			ViewBag.index = TempData["index"];
			TempData.Keep();
			return View();
		}

		//家屬照顧紀錄(照服員)-有去就醫時
		public ActionResult When_go_to_the_doctor_Home_attendant()
		{
			ViewBag.name = TempData["name"];
			ViewBag.index = TempData["index"];
			TempData.Keep();
			return View();
		}
		/*	[HttpPost]
			public ActionResult When_go_to_the_doctor(family_attend_db family_attend_db)
			{
				family_attend_db dbmanager = new family_attend_db();
				try
				{
		//			dbmanager.family_attend_db_insert(family_attend_db);
				}
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
				}
				return View();
			}*/


		//照服員-每次守護紀錄
		public ActionResult Every_guardian_the_record()
		{
			ViewBag.name = TempData["name"];
			ViewBag.index = TempData["index"];
			TempData.Keep();
			return View();
		}
		[HttpPost]
		public ActionResult Every_guardian_the_record(Guarding_records_every guarding_records_every)
		{
			Guarding_records_every_db guarding_records_every_db = new Guarding_records_every_db();
			//	try
			//	{
			//		guarding_records_every_db.Guarding_records_every_insert(guarding_records_every);
			//	}
			//	catch (Exception e)
			//	{
			//	//	Console.WriteLine(e.ToString());
			//	}
			return RedirectToAction("Every_guardian_the_record");
		}

		//照服員-皮膚異常
		public ActionResult Abnormal_skin()
		{
			ViewBag.name = TempData["name"];
			ViewBag.index = TempData["index"];
			TempData.Keep();
			return View();
		}

		//照服員-疼痛評估
		public ActionResult Pain_assessment_Home_attendant()
		{
			ViewBag.name = TempData["name"];
			ViewBag.index = TempData["index"];
			TempData.Keep();
			return View();
		}
		/*	[HttpPost]
			public ActionResult Pain_assessment_Home_attendant(Pain_assessment_Home_attendant pain_assessment_Home_attendant)
			{
				Pain_assessment_Home_attendant_db pain_assessment_Home_attendant_db = new Pain_assessment_Home_attendant_db();
				try
				{
					pain_assessment_Home_attendant_db.Guarding_records_every_insert(pain_assessment_Home_attendant);
				}
				catch (Exception e)
				{
					//	Console.WriteLine(e.ToString());
				}
				return RedirectToAction("Every_guardian_the_record");

			}*/

		//照服員-疼痛評估(測試)
		public ActionResult Pain_assessment_Home_attendant1()
		{
			ViewBag.name = TempData["name"];
			ViewBag.index = TempData["index"];
			TempData.Keep();
			return View();
		}

		//照服員-疼痛評估(測試)
		public ActionResult Pain_assessment_Home_attendant2()
		{
			ViewBag.name = TempData["name"];
			ViewBag.index = TempData["index"];
			TempData.Keep();
			return View();
		}

		//照服員-情緒評估
		public ActionResult Emotional_assessment_Home_attendant()
		{
			ViewBag.name = TempData["name"];
			ViewBag.index = TempData["index"];
			TempData.Keep();
			return View();
		}

		//照服員-每月守護紀錄
		public ActionResult Guardian_of_the_month_Home_attendant()
		{
			ViewBag.name = TempData["name"];
			ViewBag.index = TempData["index"];
			TempData.Keep();
			return View();
		}
		/*	[HttpPost]
			public ActionResult Guardian_of_the_month_Home_attendant(Guarding_records_every_moon Guarding_records_every_moon)
			{
				DBmanager dbmanager = new DBmanager();
				try
				{
		//			dbmanager.Guarding_records_every_moon_insert(Guarding_records_every_moon);
				}
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
				}
				return View();
			}
		*/

		//照服員-視力異常
		public ActionResult Abnormal_vision_Home_attendant()
		{
			ViewBag.name = TempData["name"];
			ViewBag.index = TempData["index"];
			TempData.Keep();
			return View();
		}

		//>照服員-聽力異常
		public ActionResult Abnormal_hearing_Home_attendant()
		{
			ViewBag.name = TempData["name"];
			ViewBag.index = TempData["index"];
			TempData.Keep();
			return View();
		}

		//照服員-語言異常
		public ActionResult Language_anomalies_Home_attendant()
		{
			ViewBag.name = TempData["name"];
			ViewBag.index = TempData["index"];
			TempData.Keep();
			return View();
		}

		//照服員-理解異常
		public ActionResult Understand_anomalies_Home_attendant()
		{
			ViewBag.name = TempData["name"];
			ViewBag.index = TempData["index"];
			TempData.Keep();
			return View();
		}

		//照服員-受虐評估
		public ActionResult Battered_assessment_Home_attendant()
		{
			ViewBag.name = TempData["name"];
			ViewBag.index = TempData["index"];
			TempData.Keep();
			return View();
		}
		/*[HttpPost]
		public ActionResult Battered_assessment_Home_attendant(abuse_db abuse_db)
		{
			abuse_db dbmanager = new abuse_db();
			try
			{
			//	dbmanager.abuse_db_insert(abuse_db);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.ToString());
			}
			return RedirectToAction("Guardian_of_the_month_Home_attendant");
		}*/

		//照服員-安全題目
		public ActionResult Safety_awareness()
		{
			return View();
		}

		//照服員-每次照顧紀錄
		public ActionResult Daily_care_record_Home_attendant()
		{
			bool care_tim = true;
			care_place_db Care_db = new care_place_db();
			List<Care_place> care = Care_db.Care_place_select(TempData["name"] as string);
			foreach (Care_place ca in care)
			{
				DateTime dt1 = DateTime.Now;
				TimeSpan time = DateTime.Now - ca.tim;
				if (time.TotalDays >= 30)
				{
					care_tim = false;
					TempData["time"] = DateTime.UtcNow.AddHours(08).AddMinutes(03);
				}

				else
					TempData["time"] = ca.tim;
			}
			if (care_tim == false)
			{
				ViewBag.care_tm = "0";
			}
			ViewBag.name = TempData["name"];
			ViewBag.index = TempData["index"];
			TempData.Keep();
			return View();

		}

		[HttpPost]
		public ActionResult Daily_care_record_Home_attendant(Care_place care_place)
		{
			care_place.usr_name = TempData["name"] as string;
			care_place.worker_name = "1";
			care_place.BA01 = TempData["BA01"] as string;
			if (Daily_care_record_Home_attendant_BA(care_place.BA01) == 1)
				care_place.BA01_tem += 1;
			care_place.BA02 = TempData["BA02"] as string;
			if (Daily_care_record_Home_attendant_BA(care_place.BA02) == 1)
				care_place.BA02_tem += 1;
			care_place.BA03 = TempData["BA03"] as string;
			if (Daily_care_record_Home_attendant_BA(care_place.BA03) == 1)
				care_place.BA03_tem += 1;
			care_place.BA04 = TempData["BA04"] as string;
			if (Daily_care_record_Home_attendant_BA(care_place.BA04) == 1)
				care_place.BA04_tem += 1;
			care_place.BA05 = TempData["BA05"] as string;
			if (Daily_care_record_Home_attendant_BA(care_place.BA05) == 1)
				care_place.BA05_tem += 1;
			care_place.BA06 = TempData["BA07"] as string;
			if (Daily_care_record_Home_attendant_BA(care_place.BA06) == 1)
				care_place.BA06_tem += 1;
			care_place.BA07 = TempData["BA08"] as string;
			if (Daily_care_record_Home_attendant_BA(care_place.BA07) == 1)
				care_place.BA07_tem += 1;
			care_place.BA08 = TempData["BA010"] as string;
			if (Daily_care_record_Home_attendant_BA(care_place.BA08) == 1)
				care_place.BA08_tem += 1;
			care_place.BA09 = "";
			if (Daily_care_record_Home_attendant_BA(care_place.BA09) == 1)
				care_place.BA09_tem += 1;
			care_place.BA10 = "";
			if (Daily_care_record_Home_attendant_BA(care_place.BA10) == 1)
				care_place.BA10_tem += 1;
			care_place.tim = (DateTime)TempData["time"];
			care_place.usr_name = (string)TempData["name"];
			care_place_db Care_db = new care_place_db();
			if (care_place.BA01_tem == 0 || (care_place.BA01 != null && care_place.BA01_tem == 1))
			{
				Care_db.Care_place_insert(care_place);
			}
			else
				Care_db.Care_place_update(care_place, care_place.tim);
			//care_place.BA09 = TempData["BA011"] as string;
			//care_place.BA10 = TempData["BA012"] as string;
			//care_place.BA011 = TempData["BA013"] as string;
			//care_place.BA01 = TempData["BA014"] as string;
			//care_place.BA01 = TempData["BA017"] as string;
			//care_place.BA01 = TempData["BA018"] as string;
			//care_place.BA01 = TempData["BA020"] as string;
			//care_place.BA01 = TempData["BA022"] as string;
			//care_place.BA01 = TempData["BA023"] as string;
			//care_place.BA01 = TempData["BA024"] as string;
			TempData.Keep();
			//care_place_db dbmanager = new care_place_db();
			//try
			//{
			//	dbmanager.Care_place_insert(care_place);
			//}
			//catch (Exception e)
			//{
			//	Console.WriteLine(e.ToString());
			//}
			return View();
		}
		public int Daily_care_record_Home_attendant_BA(string BA)
		{
			if (BA == null)
				return 0;
			else
				return 1;
		}
		//照服員-溫度照顧:溫水、溫茶、溫咖啡、寒暄、聊天、打氣......等
		public ActionResult Temperature_care()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Temperature_care(HttpPostedFileBase Temperature_careloc)
		{
			string picname = string.Format("{0}-Temperature_care.jpg", DateTime.Now.ToString("yyyyMMddHmm"));
			if (Temperature_careloc.ContentLength > 0)
			{
				var path = Path.Combine(Server.MapPath("~/Photos"), picname);
				Temperature_careloc.SaveAs(path);
			}
			TempData["Temperature_care"] = picname;
			return RedirectToAction("Daily_care_record_Home_attendant");
		}


		//照服員-必選項目 自立生活訓練
		public ActionResult Required_items_Home_attendant()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Required_items_Home_attendant(HttpPostedFileBase Required_items_Home_attendantloc)
		{
			string picname = string.Format("{0}-Required_items_Home_attendant.jpg", DateTime.Now.ToString("yyyyMMddHmm"));
			if (Required_items_Home_attendantloc.ContentLength > 0)
			{
				var path = Path.Combine(Server.MapPath("~/Photos"), picname);
				Required_items_Home_attendantloc.SaveAs(path);
			}
			TempData["Required_items_Home_attendant"] = picname;
			return RedirectToAction("Daily_care_record_Home_attendant");
		}

		//照服員-BA01 基本身體清潔
		public ActionResult BA01()
		{
			return View();
		}

		[HttpPost]
		public ActionResult BA01(HttpPostedFileBase BA01loc)
		{
			string picname = string.Format("{0}-BA01.jpg", DateTime.Now.ToString("yyyyMMddHmm"));
			if (BA01loc.ContentLength > 0)
			{
				var path = Path.Combine(Server.MapPath("~/Photos"), picname);
				BA01loc.SaveAs(path);
			}
			TempData["BA01"] = picname;
			return RedirectToAction("Daily_care_record_Home_attendant");
		}

		//照服員-BA02 基本日常照顧
		public ActionResult BA02()
		{
			return View();
		}
		[HttpPost]
		public ActionResult BA02(HttpPostedFileBase BA02loc)
		{
			string picname = string.Format("{0}-BA02.jpg", DateTime.Now.ToString("yyyyMMddHmm"));
			if (BA02loc.ContentLength > 0)
			{
				var path = Path.Combine(Server.MapPath("~/Photos"), picname);
				BA02loc.SaveAs(path);
			}
			TempData["BA02"] = picname;
			return RedirectToAction("Daily_care_record_Home_attendant");
		}
		//照服員-BA03 測量生命徵象
		public ActionResult BA03()
		{
			return View();
		}
		[HttpPost]
		public ActionResult BA03(HttpPostedFileBase BA03loc)
		{
			string picname = string.Format("{0}-BA03.jpg", DateTime.Now.ToString("yyyyMMddHmm"));
			if (BA03loc.ContentLength > 0)
			{
				var path = Path.Combine(Server.MapPath("~/Photos"), picname);
				BA03loc.SaveAs(path);
			}
			TempData["BA03"] = picname;
			return RedirectToAction("Daily_care_record_Home_attendant");
		}

		//照服員-BA04 協助進食或管灌餵食
		public ActionResult BA04()
		{
			return View();
		}
		[HttpPost]
		public ActionResult BA04(HttpPostedFileBase BA04loc)
		{
			string picname = string.Format("{0}-BA04.jpg", DateTime.Now.ToString("yyyyMMddHmm"));
			if (BA04loc.ContentLength > 0)
			{
				var path = Path.Combine(Server.MapPath("~/Photos"), picname);
				BA04loc.SaveAs(path);
			}
			TempData["BA04"] = picname;
			return RedirectToAction("Daily_care_record_Home_attendant");
		}
		//照服員-BA05 餐食照顧
		public ActionResult BA05()
		{
			return View();
		}
		[HttpPost]
		public ActionResult BA05(HttpPostedFileBase BA05loc)
		{
			string picname = string.Format("{0}-BA05.jpg", DateTime.Now.ToString("yyyyMMddHmm"));
			if (BA05loc.ContentLength > 0)
			{
				var path = Path.Combine(Server.MapPath("~/Photos"), picname);
				BA05loc.SaveAs(path);
			}
			TempData["BA05"] = picname;
			return RedirectToAction("Daily_care_record_Home_attendant");
		}
		//照服員-BA07 協助沐浴及洗頭
		public ActionResult BA07()
		{
			return View();
		}
		[HttpPost]
		public ActionResult BA07(HttpPostedFileBase BA07loc)
		{
			string picname = string.Format("{0}-BA07.jpg", DateTime.Now.ToString("yyyyMMddHmm"));
			if (BA07loc.ContentLength > 0)
			{
				var path = Path.Combine(Server.MapPath("~/Photos"), picname);
				BA07loc.SaveAs(path);
			}
			TempData["BA07"] = picname;
			return RedirectToAction("Daily_care_record_Home_attendant");
		}
		//照服員-BA08 足部照護
		public ActionResult BA08()
		{
			return View();
		}

		[HttpPost]
		public ActionResult BA08(HttpPostedFileBase BA08loc)
		{
			string picname = string.Format("{0}-BA08.jpg", DateTime.Now.ToString("yyyyMMddHmm"));
			if (BA08loc.ContentLength > 0)
			{
				var path = Path.Combine(Server.MapPath("~/Photos"), picname);
				BA08loc.SaveAs(path);
			}
			TempData["BA08"] = picname;
			return RedirectToAction("Daily_care_record_Home_attendant");
		}
		//照服員-BA10 翻身拍背
		public ActionResult BA010()
		{
			return View();
		}
		[HttpPost]
		public ActionResult BA010(HttpPostedFileBase BA10loc)
		{
			string picname = string.Format("{0}-BA10.jpg", DateTime.Now.ToString("yyyyMMddHmm"));
			if (BA10loc.ContentLength > 0)
			{
				var path = Path.Combine(Server.MapPath("~/Photos"), picname);
				BA10loc.SaveAs(path);
			}
			TempData["BA10"] = picname;
			return RedirectToAction("Daily_care_record_Home_attendant");
		}
		//照服員-BA11 肢體關節活動
		public ActionResult BA011()
		{
			return View();
		}
		[HttpPost]
		public ActionResult BA011(HttpPostedFileBase BA11loc)
		{
			string picname = string.Format("{0}-BA11.jpg", DateTime.Now.ToString("yyyyMMddHmm"));
			if (BA11loc.ContentLength > 0)
			{
				var path = Path.Combine(Server.MapPath("~/Photos"), picname);
				BA11loc.SaveAs(path);
			}
			TempData["BA11"] = picname;
			return RedirectToAction("Daily_care_record_Home_attendant");
		}
		//照服員-BA12 協助上(下)樓梯
		public ActionResult BA012()
		{
			return View();
		}
		[HttpPost]
		public ActionResult BA012(HttpPostedFileBase BA12loc)
		{
			string picname = string.Format("{0}-BA12.jpg", DateTime.Now.ToString("yyyyMMddHmm"));
			if (BA12loc.ContentLength > 0)
			{
				var path = Path.Combine(Server.MapPath("~/Photos"), picname);
				BA12loc.SaveAs(path);
			}
			TempData["BA12"] = picname;
			return RedirectToAction("Daily_care_record_Home_attendant");
		}
		//照服員-BA13 陪同外出
		public ActionResult BA013()
		{
			return View();
		}
		[HttpPost]
		public ActionResult BA013(HttpPostedFileBase BA13loc)
		{
			string picname = string.Format("{0}-BA13.jpg", DateTime.Now.ToString("yyyyMMddHmm"));
			if (BA13loc.ContentLength > 0)
			{
				var path = Path.Combine(Server.MapPath("~/Photos"), picname);
				BA13loc.SaveAs(path);
			}
			TempData["BA13"] = picname;
			return RedirectToAction("Daily_care_record_Home_attendant");
		}
		//照服員-BA14 陪同就醫
		public ActionResult BA014()
		{
			return View();
		}
		[HttpPost]
		public ActionResult BA014(HttpPostedFileBase BA14loc)
		{
			string picname = string.Format("{0}-BA14.jpg", DateTime.Now.ToString("yyyyMMddHmm"));
			if (BA14loc.ContentLength > 0)
			{
				var path = Path.Combine(Server.MapPath("~/Photos"), picname);
				BA14loc.SaveAs(path);
			}
			TempData["BA14"] = picname;
			return RedirectToAction("Daily_care_record_Home_attendant");
		}
		//照服員-BA17 協助輔助性醫療
		public ActionResult BA017()
		{
			return View();
		}
		[HttpPost]
		public ActionResult BA017(HttpPostedFileBase BA17loc)
		{
			string picname = string.Format("{0}-BA17.jpg", DateTime.Now.ToString("yyyyMMddHmm"));
			if (BA17loc.ContentLength > 0)
			{
				var path = Path.Combine(Server.MapPath("~/Photos"), picname);
				BA17loc.SaveAs(path);
			}
			TempData["BA17"] = picname;
			return RedirectToAction("Daily_care_record_Home_attendant");
		}
		//照服員-BA18 安全看視
		public ActionResult BA018()
		{
			return View();
		}
		[HttpPost]
		public ActionResult BA018(HttpPostedFileBase BA18loc)
		{
			string picname = string.Format("{0}-BA18.jpg", DateTime.Now.ToString("yyyyMMddHmm"));
			if (BA18loc.ContentLength > 0)
			{
				var path = Path.Combine(Server.MapPath("~/Photos"), picname);
				BA18loc.SaveAs(path);
			}
			TempData["BA18"] = picname;
			return RedirectToAction("Daily_care_record_Home_attendant");
		}
		//照服員-BA20 陪伴服務
		public ActionResult BA020()
		{
			return View();
		}
		[HttpPost]
		public ActionResult BA020(HttpPostedFileBase BA20loc)
		{
			string picname = string.Format("{0}-BA20.jpg", DateTime.Now.ToString("yyyyMMddHmm"));
			if (BA20loc.ContentLength > 0)
			{
				var path = Path.Combine(Server.MapPath("~/Photos"), picname);
				BA20loc.SaveAs(path);
			}
			TempData["BA20"] = picname;
			return RedirectToAction("Daily_care_record_Home_attendant");
		}
		//照服員-BA22 巡視服務
		public ActionResult BA022()
		{
			return View();
		}
		[HttpPost]
		public ActionResult BA022(HttpPostedFileBase BA22loc)
		{
			string picname = string.Format("{0}-BA22.jpg", DateTime.Now.ToString("yyyyMMddHmm"));
			if (BA22loc.ContentLength > 0)
			{
				var path = Path.Combine(Server.MapPath("~/Photos"), picname);
				BA22loc.SaveAs(path);
			}
			TempData["BA22"] = picname;
			return RedirectToAction("Daily_care_record_Home_attendant");
		}
		//照服員-BA23 協助洗頭
		public ActionResult BA023()
		{
			return View();
		}
		[HttpPost]
		public ActionResult BA023(HttpPostedFile BA23loc)
		{
			string picname = string.Format("{0}-BA23.jpg", DateTime.Now.ToString("yyyyMMddHmm"));
			if (BA23loc.ContentLength > 0)
			{
				var path = Path.Combine(Server.MapPath("~/Photos"), picname);
				BA23loc.SaveAs(path);
			}
			TempData["BA23"] = picname;
			return RedirectToAction("Daily_care_record_Home_attendant");
		}
		//照服員-BA24 協助排泄
		public ActionResult BA024()
		{
			return View();
		}
		[HttpPost]
		public ActionResult BA024(HttpPostedFileBase BA24loc)
		{
			string picname = string.Format("{0}-BA24.jpg", DateTime.Now.ToString("yyyyMMddHmm"));
			if (BA24loc.ContentLength > 0)
			{
				var path = Path.Combine(Server.MapPath("~/Photos"), picname);
				BA24loc.SaveAs(path);
			}
			TempData["BA24"] = picname;
			return RedirectToAction("Daily_care_record_Home_attendant");
		}
		//照服員-照顧交辦單
		public ActionResult Take_care_of_page()
		{
			return View();
		}

		//照服員-轉場頁面
		public ActionResult Transitions()
		{
			return View();
		}

		//照服員-異常事件執行表
		public ActionResult Abnormal_event_execution_table()
		{
			Exception_notification_db exception_notification_db = new Exception_notification_db();
			List<Exception_notification> exception_notifications = exception_notification_db.GetException_notification();
			ViewBag.exception_notifications = exception_notifications;
			return View();
		}


		//照服員-異常事件執行
		public ActionResult Abnormal_event_execution()
		{
			return View();
		}

		//照服員-異常事件執行追蹤
		public ActionResult Abnormal_event_tracking()
		{
			return View();
		}



		//督導-工作手冊
		public ActionResult Workbook_Home_Service_Supervisor()
		{
			return View();
		}

		//督導-緊急意外流程
		public ActionResult Emergency_accident_handling_process_Home_Service_Supervisor()
		{
			return View();
		}

		//督導-居督網路打卡頁面
		public ActionResult Home_Service_Supervisor_sign_index()
		{
			return View();
		}

		//督導-上班打卡
		public ActionResult Home_Service_Supervisor_sign_success()
		{
			return View();
		}
		[HttpPost]
		public ActionResult Home_Service_Supervisor_sign_success(Daycheck daycheck)
		{
			worker_arrive_db worker_db = new worker_arrive_db();

			worker_db.worker_arrive_insert(TempData["name"] as string);
			TempData.Keep();

			return RedirectToAction("Select_case_schedule");
		}
		//督導-下班打卡
		public ActionResult Home_Service_Supervisor_sign_out()
		{
			return View();
		}
		[HttpPost]
		public ActionResult Home_Service_Supervisor_sign_out(worker_arrive worker_arrive)
		{
			worker_arrive_db dbmanager = new worker_arrive_db();
			dbmanager.worker_arrive_update(TempData["name"] as string);
			
			return RedirectToAction("Login");
		}

		//督導-居督平板主頁面
		public ActionResult Home_Service_Supervisor_index()
		{
			return View();
		}

		//督導-(開案)個案選擇頁
		public ActionResult Case_selection_page_Home_Service_Supervisor()
		{
			return View();
		}

		//督導-(開案)個案基本資料
		public ActionResult Case_basic_information_Home_Service_Supervisor()
		{
			return View();
		}

		//督導-(開案)個案個別化照顧
		public ActionResult Single_case_care_Home_Service_Supervisor()
		{
			return View();
		}

		//督導-(開案)壓力照顧量表
		public ActionResult Care_Stress_Scale_Home_Service_Supervisor()
		{
			return View();
		}

		//督導-(開案)壓力資源量表
		public ActionResult Care_Resource_Scale_Home_Service_Supervisor()
		{
			return View();
		}

		//督導-(開案)個案疾病史
		public ActionResult Case_history_Home_Service_Supervisor()
		{
			return View();
		}

		//督導-(開案)跌倒評估
		public ActionResult Fall_assessment_Home_Service_Supervisor()
		{
			return View();
		}

		//督導-(開案)其他評估
		public ActionResult Other_assessments_Home_Service_Supervisor()
		{
			return View();
		}

		//督導-(開案)個案資料上傳
		public ActionResult Information_upload_Home_Service_Supervisor()
		{
			return View();
		}
		//	[HttpPost]
		//	public ActionResult Information_upload_Home_Service_Supervisor(user_basic_db user_basic_db)
		//	{
		//		user_basic_db dbmanager = new user_basic_db();
		//		try
		//		{
		//		dbmanager.user_basic_db_insert(user_basic_db);
		//		}
		//		catch (Exception e)
		//		{
		//			Console.WriteLine(e.ToString());
		//		}
		//	}


		//督導-(複評)個案選擇頁
		public ActionResult Reopen_Case_selection_page_Home_Service_Supervisor()
		{
			return View();
		}

		//督導-(複評)個案基本資料
		public ActionResult Reopen_Case_basic_information_Home_Service_Supervisor()
		{
			return View();
		}

		//督導-(複評)個案個別化照顧
		public ActionResult Reopen_Single_case_care_Home_Service_Supervisor()
		{
			return View();
		}

		//督導-(複評)壓力照顧量表
		public ActionResult Reopen_Care_Stress_Scale_Home_Service_Supervisor()
		{
			return View();
		}

		//督導-(複評)壓力資源量表
		public ActionResult Reopen_Care_Resource_Scale_Home_Service_Supervisor()
		{
			return View();
		}

		//督導-(複評)個案疾病史
		public ActionResult Reopen_Case_history_Home_Service_Supervisor()
		{
			return View();
		}

		//督導-(複評)跌倒評估h
		public ActionResult Reopen_Fall_assessment_Home_Service_Supervisor()
		{
			return View();
		}

		//督導-(評估)其他評估
		public ActionResult Reopen_Other_assessments_Home_Service_Supervisor()
		{
			return View();
		}

		//督導-(複評)個案資料上傳
		public ActionResult Reopen_Information_upload_Home_Service_Supervisor()
		{
			return View();
		}
		//	[HttpPost]
		//	public ActionResult Reopen_Information_upload_Home_Service_Supervisor(user_basic_db user_basic_db)
		//	{
		//		user_basic_db dbmanager = new user_basic_db();
		//		try
		//		{
		//			dbmanager.user_basic_db_insert(user_basic_db);
		//		}
		//		catch (Exception e)
		//		{
		//			Console.WriteLine(e.ToString());
		//		}
		//	}


		//照服員-員工申訴
		public ActionResult Employee_complaint_Home_attendant()
		{
			return View();
		}
		[HttpPost]
		public ActionResult Employee_complaint_Home_attendant(Appeal appeal, HttpPostedFileBase appealphoto)
		{
			appeal.pic_one = string.Format("{0}-{1}.jpg", DateTime.Now.ToString("yyyyMMddHmm"), appeal.US_name);
			appeal.tim = DateTime.Now;
			Appeal_db appeal_db = new Appeal_db();
			appeal_db.appeal_insert(appeal);
			string fileName = "";
			if (appealphoto != null)
			{
				if (appealphoto.ContentLength > 0)
				{
					fileName = Path.GetFileName(appealphoto.FileName);
					var path = Path.Combine(Server.MapPath("~/Photos"), appeal.pic_one);
					appealphoto.SaveAs(path);
				}
			}
			return RedirectToAction("Employee_complaint_Home_attendant");

		}
		//}
		public string ShowPhotos()
		{
			string show = "";
			DirectoryInfo dir = new DirectoryInfo(Server.MapPath("~/Photos"));
			FileInfo[] fInfo = dir.GetFiles();
			int n = 0;
			foreach (FileInfo result in fInfo)
			{
				n++;
				show += "<a href='../Photos/" + result.Name + " ' target='_blank'><img src='../Photos/" + result.Name + "'width='90' height='60' border='0'></a>";
				if (n % 4 == 0)
				{
					show += "<p>";
				}
			}
			show += "<p><a href='Employee_complaint_Home_attendant'>返回</a></p>";
			return show;

		}

		//照服員-成功申報
		public ActionResult Employee_complaint_success_Home_attendant()
		{
			return View();
		}

		//照服員-異常事件通報
		public ActionResult Abnormal_events_reactions_Home_attendant()
		{
			return View();
		}
		[HttpPost]
		public ActionResult Abnormal_events_reactions_Home_attendant(Exception_notification exception_notification)
		{
			Exception_notification_db exception_notification_db = new Exception_notification_db();
			try
			{
				exception_notification_db.sign_in_db_insert(exception_notification);
			}
			catch (Exception e)
			{
				//	Console.WriteLine(e.ToString());
			}
			return RedirectToAction("Index");
		}
		public ActionResult Index()
		{
			Exception_notification_db exception_notification_db = new Exception_notification_db();
			List<Exception_notification> exception_notifications = exception_notification_db.GetException_notification();
			ViewBag.exception_notifications = exception_notifications;
			return View();

		}
	}
}
