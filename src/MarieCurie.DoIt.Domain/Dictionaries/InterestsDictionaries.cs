using System;
using System.Collections.Generic;

namespace MarieCurie.DoIt.Domain.Dictionaries
{
    public static class InterestsDictionaries
    {
        public static Dictionary<string, Dictionary<string, Guid>> AllInterests()
        {
            var dictionary = new Dictionary<string, Dictionary<string, Guid>>();
            dictionary.Add("Professions", ProfessionInterests());
            dictionary.Add("Education", EducationInterests());
            dictionary.Add("Environmental", EnvironmentalInterests());
            dictionary.Add("Culture & Sport", CultureAndSportInterests());
            dictionary.Add("Crisis & Poverty", CrisisAndPovertyInterests());
            dictionary.Add("Communities", CommunitiesInterests());
            dictionary.Add("Crime & Justice", CrimeAndJusticeInterests());
            dictionary.Add("Health & Social Care", HealthAndSocialCareInterests());
            dictionary.Add("People Youth & Family", PeopleYouthAndFamilyInterests());

            return dictionary;
        }

        public static Dictionary<string, Guid> ProfessionInterests()
        {
            //see https://docs.google.com/document/d/1Lrou9k0LGXh624z7R0TQhcTBg3--07RGiKzDWrOJWVA/edit for full list

            var dictionary = new Dictionary<string, Guid>
            {
                {"Media",           new Guid("0bf99f84-89f8-49ce-9957-df8b60660bfd")},
                {"Marketing",       new Guid("7fd92e8e-c71a-40a3-a806-bcef228863b9")},
                {"Health & Safety", new Guid("c904084b-934a-4915-9937-833020adfe6d")},
                {"IT",              new Guid("8832e673-44fc-4771-a66d-40dfb9d038da")},
                {"Legal",           new Guid("b1c8f0ab-5205-40b1-842d-e9f0a3f97476")},
                {"Retail",          new Guid("02ec4725-94fa-492c-8f90-7d781905c168")}
            };

            return dictionary;
        }

        public static Dictionary<string, Guid> EducationInterests()
        {
            var dictionary = new Dictionary<string, Guid>
            {
                {"Education", new Guid ("517978aa-186d-4149-8548-c26b3d3f41cc")},
                {"Museums", new Guid ("f877eb40-6d22-4c17-9c70-e902d5f1d263")},
                {"Heritage", new Guid ("1b6205f2-02f8-4fc3-808c-e8e6b9e03c0e")},
                {"Literacy", new Guid("f76f8162-e300-403b-9c96-bae336cb9330")},
                {"Libraries", new Guid("97d6e59e-3ddd-4d76-8cde-e992049c40fc")}
            };

            return dictionary;
        }

        public static Dictionary<string, Guid> EnvironmentalInterests()
        {
            var dictionary = new Dictionary<string, Guid>
            {
	            {"Environment", new Guid ("a294c916-dfbb-4eed-aa76-13e380d62b50")},
	            {"Animals",new Guid ("4b5f270f-723f-4aec-bbc4-6f257c3ddafa")},
	            {"Wildlife", new Guid ("6dd234b9-ce8d-439e-9379-a4093a4e8f6c")},
	            {"Conservation", new Guid ("6818a00c-4b32-4838-9af4-66b7457310b0")}
            };
            return dictionary;
        }

        public static Dictionary<string, Guid> CultureAndSportInterests()
        {
            var dictionary = new Dictionary<string, Guid>
            {
              	{"Festivals", new Guid ("c125887f-f06a-47f9-ae55-942bf6e0aeda")},
	            {"Performance", new Guid ("a654354a-943f-4a5f-926e-33d27889f19d")},
	            {"Drama", new Guid ("1c5c36b7-882d-497d-8247-0515f2045cbf")},
	            {"Sport", new Guid ("2a13e327-cdc3-4a63-a737-52c29ee8f454")},
	            {"Craft", new Guid ("42c360a5-4e90-4bc4-afcd-c8f5ccc09a31")},
	            {"Music", new Guid ("49c16b59-d3a5-4d49-ae9c-2e665f092643")},
	            {"Art", new Guid ("c2d0eab4-7363-4e91-8e15-02364e8422e4")},
	            {"Film", new Guid ("bf021406-7d4c-46d5-9bf9-c8fe09308797")},
	            {"Public events", new Guid ("ef94a8bb-eb86-494e-bb0c-44653280dd89")},
	            {"Recreation", new Guid ("c1a66cf8-a685-4300-8f69-6d47a0bd93e0")}
            };
            return dictionary;
        }

        public static Dictionary<string, Guid> CrisisAndPovertyInterests()
        {
            var dictionary = new Dictionary<string, Guid>
            {
          		{"Poverty", new Guid ("14e14b9c-586f-4e31-8627-7dc02a99d816")},
	            {"Disaster relief", new Guid ("089a30e6-a5a5-41fb-a4b3-9d7edd2de196")},
	            {"Unemployed", new Guid ("2326507a-d5fb-427a-a317-4f4988d37ad6")},
	            {"International Aid", new Guid ("6cb0fa97-3ee5-473d-929f-82a6c2ca7b6e")},
	            {"Emergency services", new Guid ("2cdfc8a6-0d08-4b9e-a252-389b516b4357")},
	            {"Food banks", new Guid ("0f0fd0f9-845f-415e-a94c-5762b9060b54")},
	            {"Refugees", new Guid ("d5d2ee64-8925-43be-888d-1eaf4df36452")},
	            {"Homeless", new Guid ("65b5d8c5-abe4-47bb-9b74-e6c0cec97ae8")},
	            {"Crisis Support", new Guid ("fc99930f-61e0-4dde-a941-79d9da4d3192")},
	            {"Housing", new Guid ("06bd90b2-65c3-4d67-8233-b1e44c35f184")},
	            {"Hunger", new Guid ("cedd69ea-dd49-453b-96ff-a6ec5d14c4df")}
            };
            return dictionary;
        }

        public static Dictionary<string, Guid> CommunitiesInterests()
        {
            var dictionary = new Dictionary<string, Guid>
            {
          		{"Women", new Guid ("4dec176f-78db-42bc-8b81-f73ac6c482f3")},
	            {"Men", new Guid ("8841ad2a-f281-4fbf-a5e3-2c84529f9544")},
	            {"LGBT", new Guid ("e51615c1-31d7-4236-8126-6310a6812186")},
	            {"Faith", new Guid ("e7cd6081-45c1-401a-b321-e1d679612948")},
	            {"Race & Ethnicity", new Guid ("0c1d7fc3-2589-431e-bdd3-3557adb98ef6")},
	            {"Immigrants", new Guid ("12d24d50-d807-42a2-a58b-301403429dca")}
            };
            return dictionary;
        }

        public static Dictionary<string, Guid> CrimeAndJusticeInterests()
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

        public static Dictionary<string, Guid> HealthAndSocialCareInterests()
        {
            var dictionary = new Dictionary<string, Guid>
            {
          		{"Veterans & Armed Forces", new Guid ("db257ffa-ab8d-4f6e-8970-222971e6621a")},
	            {"Addiction", new Guid ("323b7713-bea6-484d-ac6a-7f5bdc9872d2")},
	            {"Social care", new Guid ("6fc9bb15-1728-4d4d-bdab-51be247acba0")},
	            {"Disability", new Guid ("484cccef-29f7-463f-97e0-385657bc58da")},
	            {"Hospices", new Guid ("8b373b98-7987-481e-bf4e-16edef3501f4")},
	            {"Mental Health", new Guid ("397cac61-1077-4f78-a8e5-d8c3dd29cde4")},
	            {"Medicine", new Guid ("52bd46a8-63d2-47d8-b4a1-785f8215da59")}
            };
            return dictionary;
        }

        public static Dictionary<string, Guid> PeopleYouthAndFamilyInterests()
        {
            var dictionary = new Dictionary<string, Guid>
            {
          		{"Older people", new Guid ("3fd515b4-6e1a-41a1-bad9-ea401937555b")},
	            {"Families", new Guid ("8678f792-d24e-4810-99d5-c6e6ba4196a4")},
	            {"Young people", new Guid ("02b052fd-4f3d-418b-9542-0b980533b03b")},
	            {"Children", new Guid ("8f0a66e0-30e7-4bdd-a190-7a9a36afcedd")}
            };
            return dictionary;
        }
    }
}