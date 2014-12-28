using System;
using System.Collections;
using System.Collections.Generic;

namespace MarieCurie.DoIt.Domain.Dictionaries
{
    public static class ActivitiesDictionaries
    {
        public static Dictionary<string, Dictionary<string, Guid>> AllActivities()
        {
            var dictionary = new Dictionary<string, Dictionary<string, Guid>>();
            dictionary.Add("Practical", PracticalActivities());
            dictionary.Add("Professional", ProfessionalActivities());
            dictionary.Add("Promoting & Fundraising", PromotingAndFundraisingActivities());
            dictionary.Add("Office", OfficeActivities());
            dictionary.Add("Supporting Others", SupportingOthersActivities());
            dictionary.Add("Technology & Online", TechnologyAndOnlineActivities());
            dictionary.Add("Teaching & Training", TeachingAndTrainingActivities());

            return dictionary;
        }

        public static Hashtable GetAllActivitiesHashtable()
        {
            var ht = new Hashtable();
            foreach(var a in AllActivities())
            {
                foreach (var aa in a.Value)
                    ht.Add(aa.Key, aa.Value);
            }

            return ht;
        }

        public static Dictionary<string, Guid> PracticalActivities()
        {
            var dictionary = new Dictionary<string, Guid>
            {
	            {"Stewarding", new Guid ("4116876a-5ab3-491b-aa82-5fa73b4b0de4")},
	            {"Policing", new Guid ("e20eec41-1c0d-4713-9fbe-43a28fe85ffe")},
	            {"Gardening", new Guid ("05e66533-2307-4062-b265-483d641fddd5")},
	            {"Construction", new Guid ("1ec3af8d-1f67-4dbe-8a70-d81278deaa3b")},
	            {"Retail", new Guid ("ab316d54-9f67-4e8f-9cd8-17ee924ff702")},
	            {"First Aid", new Guid ("8deb3515-22ee-4928-80fd-6af407c7d4ef")},
	            {"DIY / Odd Jobs", new Guid ("8b73b3cd-82b8-4086-8574-a466a4de1aae")},
	            {"Design", new Guid ("e0aa4de2-dd2a-4cf4-8f15-4fb99ea848ea")},
	            {"Outdoors", new Guid ("e7a24e4d-f0e6-4e62-9ba1-6199eafa7aab")},
	            {"Driving", new Guid ("8b9fea44-c596-4444-a4ef-3798d44f73a6")},
	            {"Catering", new Guid ("38d6bd73-8fed-4749-9420-d11516b46c6e")}
	        };

            return dictionary;
        }

        public static Dictionary<string, Guid> ProfessionalActivities()
        {
            var dictionary = new Dictionary<string, Guid>
            {
	            {"Financial control", new Guid ("4220adce-22ce-4106-947f-c09b1d654a19")},
	            {"Management", new Guid ("c181b435-9a37-408c-a1e5-d89bff380397")},
	            {"Interpretation", new Guid ("91840723-c526-4025-86f7-629410ee8445")},
	            {"Legal work", new Guid ("b0ae23f9-e0c4-48d0-8581-c3677134cf49")},
	            {"Accountancy", new Guid ("796605b9-7045-45a8-ae11-c1478a55af79")},
	            {"Translation", new Guid ("fbeb63e1-a69b-4761-a813-8f02e194398f")},
	            {"Business Development", new Guid ("021cb3ae-c93b-4ebc-9284-abbf59f1653d")},
	            {"Trusteeship", new Guid ("7c2cd327-9c8f-4c72-8f32-3d540741c890")}
	        };

            return dictionary;
        }

        public static Dictionary<string, Guid> PromotingAndFundraisingActivities()
        {
            var dictionary = new Dictionary<string, Guid>
            {
	            {"Lobbying", new Guid ("906cde21-81b0-4fa0-b963-96f06f936527")},
	            {"Marketing", new Guid ("9caa702b-3b6a-4e3a-a5bb-4ac875d1a597")},
	            {"Fundraising", new Guid ("27e17f2e-8505-4c77-a35e-8c86631fcf66")},
	            {"Campaigning", new Guid ("de53e67b-2e3b-4fab-86fa-c30c4f81a03d")},
	            {"Social media", new Guid ("2a614841-743d-4d54-866d-f3f9018ed778")}
	        };
            return dictionary;
        }

        public static Dictionary<string, Guid> OfficeActivities()
        {
            var dictionary = new Dictionary<string, Guid>
            {
	            {"Administration", new Guid ("b6e73ade-c18b-45c0-938e-3cf9e6357981")},
	            {"Receptionist", new Guid ("10e1992c-756c-46f5-bfcc-61063877766e")},
	            {"Research", new Guid ("bbb018c9-6d92-437d-b2e0-75d82c340d0f")}
			};

            return dictionary;
        }

        public static Dictionary<string, Guid> SupportingOthersActivities()
        {
            var dictionary = new Dictionary<string, Guid>
            {
	            {"Mentoring", new Guid ("13a22b00-23d7-4412-85f3-975856c91996")},
	            {"Counselling", new Guid ("b2695615-f1a3-429a-969b-7ffa96e4dc97")},
	            {"Hostels", new Guid ("cf3f5abc-6bba-4896-8a41-db1190701716")},
	            {"Care work", new Guid ("95dcfbef-4480-4e4d-ba2d-93f4c193cbfa")},
	            {"Befriending", new Guid ("9b65e7e8-9a68-48ab-9af1-dc069ed90c09")},
	            {"Support work", new Guid ("b72ef27c-47dd-41b3-b629-41ef3d3ef95c")},
	            {"Providing advice", new Guid ("9e4c6d8d-6c7c-4f67-b01d-76feec16f5b8")},
	            {"Food banks", new Guid ("08ab6080-2611-40ff-aef8-ed760ab04cd3")},
	            {"Escorting", new Guid ("f4144b00-281b-489d-b1dc-10de5a84fd5f")}
	        };

            return dictionary;
        }

        public static Dictionary<string, Guid> TechnologyAndOnlineActivities()
        {
            var dictionary = new Dictionary<string, Guid>
            {
	            {"IT", new Guid ("329be453-05b1-4ab6-a2f4-eee9d33cb38d")},
	            {"Technology", new Guid ("e3f118c6-820a-4a60-8c3c-a8fb60ee8dbc")},
	            {"Web development", new Guid ("1da240c2-0d8d-460e-a61a-ccecebd40421")},
	            {"Virtual volunteering", new Guid ("9aa3f970-c13b-4b04-bbb7-4d64cd66c6fe")},
	        };
            return dictionary;
        }

        public static Dictionary<string, Guid> TeachingAndTrainingActivities()
        {
            var dictionary = new Dictionary<string, Guid>
            {
          		{"Justice", new Guid ("8d67d71d-62b3-41b4-93ed-dd7abf27f4cf")},
	            {"Politics", new Guid ("a780d884-e307-40cd-8325-366ce3b72d84")},
	            {"Civil rights", new Guid ("74095951-f0ef-441c-85f4-949304ff6b89")},
	            {"Ex-offenders", new Guid ("ea047609-577d-4cfb-a90f-1e7f3eb247ee")},
	            {"Victim support",new Guid ("5052c4dc-875f-4f9b-912d-f587b7072189")},
	            {"Human rights", new Guid ("98f6b247-f07a-430d-a181-9ec00f443da5")},
	            {"Domestic violence", new Guid ("3d8a60ac-732f-4522-a9a7-7e564f16c5da")},
	            {"Prisoners", new Guid ("ca8badda-d7eb-4c75-9e9a-ef220689e53f")},
	            {"Crime", new Guid ("328ece49-0076-4dfe-a0ea-4991741ad175")}
            };
            return dictionary;
        }
    }
}