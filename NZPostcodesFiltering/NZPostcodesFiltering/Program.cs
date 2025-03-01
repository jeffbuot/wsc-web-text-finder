﻿// Data is based from this website https://www.addysolutions.com/nz-postcode-list

var nzRegionalPostCodes = new Dictionary<string, string[]>
{
    {
        "Nelson",
        ["7010", "7011", "7011", "7040", "7041", "7042", "7043", "7044", "7045", "7047", "7071", "7020", "7081"]
    },
    {
        "Tasman",
        [
            "7022", "7051", "7091", "7054", "7073", "7005", "7048", "7120", "7143", "7196",
            "7197", "7198", "7007", "7049", "7077", "7010", "7011", "7040", "7041", "7042",
            "7043", "7044", "7045", "7047", "7071", "7072", "7020", "7020", "7050", "7081",
            "7081", "7146", "7053", "7110", "7142", "7182", "7183", "7055", "7144", "7173",
            "7175", "7025", "7052", "7095", "7096"
        ]
    },
    {
        "Marlborough",
        [
            "7201", "7202", "7206", "7240", "7241", "7271", "7272", "7273", "7274", "7275",
            "7276", "7193", "7100", "7150", "7178", "7220", "7250", "7251", "7281", "7282",
            "7284", "7145", "7192", "7194", "7195", "7204", "7243", "7210", "7247", "7285",
            "7202", "7244", "7246", "7248"
        ]
    },
    {
        "West Coast",
        [
            "7843", "7804", "7871", "7871", "7836", "7865", "7872", "7859", "7856", "7823",
            "7802", "7803", "7805", "7832", "7840", "7849", "7844", "7863", "7884", "7822",
            "7867", "7810", "7811", "7842", "7881", "7882", "7883", "7846", "7855", "7864",
            "7893", "7832", "7861", "7875", "7875", "7062", "7845", "7824", "7830", "7851",
            "7895", "7812", "7860", "7885", "7803", "7841", "7873", "7873", "7847", "7848",
            "7825", "7866", "7891", "7892", "7857", "7886"
        ]
    },
    {
        "Canterbury",
        [
            "7520", "7542", "7550", "7552", "7581", "7582", "7583", "7410", "7441", "7481",
            "7481", "7482", "7483", "7946", "7654", "7700", "7740", "7741", "7742", "7746",
            "7771", "7772", "7773", "7774", "7775", "7776", "7777", "7778", "7670", "7600",
            "7957", "7984", "7984", "7984", "7310", "7341", "7381", "7382", "7383", "7384",
            "7671", "7671", "7672", "7672", "7674", "7674", "7675", "7676", "7676", "7677",
            "7678", "7678", "8011", "8013", "8014", "8022", "8023", "8024", "8025", "8025",
            "8041", "8042", "8042", "8051", "8052", "8053", "8061", "8062", "8081", "8083",
            "8140", "8141", "8143", "8145", "8146", "8147", "8148", "8149", "8154", "8240",
            "8241", "8242", "8244", "8245", "8247", "8440", "8441", "8442", "8443", "8444",
            "8446", "8542", "8543", "8544", "8545", "8548", "8640", "8641", "8643", "8840",
            "8842", "7646", "7673", "7345", "7391", "7392", "7444", "7510", "7541", "7571",
            "7572", "8941", "8972", "7548", "7657", "7545", "7925", "7949", "7987", "7987",
            "7930", "7956", "7991", "7992", "7387", "7334", "7360", "7348", "7385", "7747",
            "7544", "7630", "7644", "7691", "7692", "7260", "7300", "7340", "7371", "7373",
            "7373", "7374", "7630", "7543", "9435", "9446", "9498", "9498", "7945", "7632",
            "7656", "7682", "7683", "7446", "7608", "7640", "7647", "7546", "7591", "8082",
            "8841", "8971", "7730", "7745", "7791", "9491", "9494", "9448", "9412", "9447",
            "7430", "7443", "7495", "7912", "7990", "7612", "7648", "7903", "7947", "7982",
            "7982", "7983", "7604", "7710", "7743", "7781", "7782", "7782", "7783", "7784",
            "7400", "7440", "7471", "7472", "7472", "7473", "7475", "7476", "7477", "7477",
            "7614", "7615", "7643", "7650", "7658", "7379", "7445", "7500", "7580", "7602",
            "7642", "7649", "7681", "7616", "7988", "7645", "7920", "7948", "7985", "7986",
            "7630", "7910", "7940", "7941", "7942", "7943", "7971", "7971", "7972", "7972",
            "7973", "7974", "7975", "7901", "7944", "7500", "7332", "7343", "7395", "7420",
            "7442", "7491", "7402", "7448", "7924", "7960", "7977", "7978", "7979", "7980",
            "7447", "7618", "7958", "7610", "7641"
        ]
    },
    {
        "Otago", [
            "9320", "9340", "9391", "9392", "9393", "9302", "9351", "9230", "9240", "9271",
            "9272", "9273", "9274", "9091", "9091", "9534", "9548", "9583", "9584", "9330",
            "9341", "9310", "9342", "9383", "9383", "9384", "9010", "9011", "9012", "9013",
            "9014", "9016", "9018", "9022", "9035", "9040", "9041", "9042", "9043", "9044",
            "9045", "9046", "9047", "9048", "9049", "9052", "9054", "9059", "9076", "9077",
            "9350", "9372", "9771", "9772", "9775", "9410", "9442", "9210", "9281", "9282",
            "9748", "9345", "9532", "9543", "9591", "9593", "9346", "9067", "9596", "9597",
            "9598", "9598", "9544", "9220", "9241", "9291", "9292", "9024", "9053", "9092",
            "9354", "9400", "9401", "9444", "9491", "9492", "9493", "9494", "9495", "9352",
            "9376", "9377", "9386", "9387", "9019", "9062", "9073", "9073", "9074", "9074",
            "9535", "9546", "9585", "9586", "9430", "9443", "9481", "9482", "9483", "9023",
            "9050", "9081", "9082", "9300", "9302", "9304", "9348", "9349", "9371", "9332",
            "9353", "9395", "9396", "9397", "9397", "9398", "9441", "9500", "9571", "9572",
            "9572", "9231", "9522", "9542", "9587", "9587", "9347", "9243", "9471", "9471",
            "9472", "9472", "9510", "9541", "9069", "9085", "9305", "9343", "9344", "9382",
            "9449", "9355"
        ]
    },
    {
        "Southland", [
            "9749", "9746", "9779", "9814", "9842", "9752", "9791", "9825", "9848", "9750",
            "9710", "9740", "9771", "9772", "9773", "9773", "9774", "9774", "9775", "9776",
            "9776", "9777", "9777", "9810", "9812", "9840", "9841", "9843", "9844", "9845",
            "9871", "9871", "9872", "9872", "9874", "9874", "9875", "9876", "9876", "9877",
            "9877", "9879", "9879", "9730", "9742", "9792", "9793", "9794", "9643", "9356",
            "9712", "9646", "9747", "9630", "9644", "9635", "9610", "9641", "9682", "9683",
            "9689", "9744", "9822", "9847", "9881", "9883", "9846", "9600", "9640", "9672",
            "9679", "9884", "9620", "9642", "9691", "9745", "9778", "9816", "9720", "9741",
            "9781", "9782", "9783", "9831", "9849", "9891", "9892", "9892", "9893"
        ]
    },
    {
        "Greater Wellington", [
            "5713", "5743", "5791", "5792", "5792", "4994", "4996", "4996", "5710", "5740",
            "5771", "5772", "5773", "5712", "5742", "5794", "6972", "5573", "5010", "5011",
            "5012", "5013", "5014", "5018", "5019", "5019", "5040", "5041", "5042", "5044",
            "5045", "5047", "5048", "5049", "5050", "5141", "5711", "5741", "5781", "5782",
            "5783", "5784", "5810", "5840", "5842", "5846", "5871", "5872", "5872", "5881",
            "5882", "5883", "5883", "5884", "5884", "5884", "5885", "5886", "5887", "5888",
            "5889", "5890", "5890", "5512", "5542", "5581", "5582", "5583", "5032", "5034",
            "5258", "5032", "5036", "5252", "5254", "5255", "5022", "5024", "5026", "5240",
            "5242", "5245", "5247", "5381", "5381", "5026", "5544", "5894", "5018", "5019",
            "5140", "5142", "5143", "5371", "5372", "5036", "5250", "5391", "5373", "5016",
            "5028", "5249", "6011", "6012", "6021", "6022", "6023", "6035", "6037", "6140",
            "6141", "6142", "6143", "6144", "6147", "6150", "6160", "6241", "6242", "6243",
            "6440", "6441", "6442", "6443"
        ]
    },
    {
        "Hawke's Bay", [
            "4102", "4148", "4970", "4120", "4122", "4153", "4154", "4155", "4156", "4159",
            "4171", "4171", "4172", "4174", "4175", "4178", "4178", "4179", "4180", "4102",
            "4122", "4130", "4150", "4157", "4294", "4295", "4295", "4188", "4188", "4166",
            "4104", "4110", "4112", "4140", "4141", "4142", "4143", "4144", "4145", "4149",
            "4151", "4181", "4182", "4182", "4183", "4183", "4184", "4186", "4165", "4198",
            "4244", "4278", "4279", "4202", "4241", "4276", "4276", "4277", "4245", "4291",
            "4292", "4293", "4189", "4792", "4203", "4243", "4286", "4287", "4288", "3379",
            "4102", "4164", "4162", "4210", "4240", "4271", "4272", "4273", "4274", "4274",
            "4275", "4200", "4242", "4281", "4282", "4283", "4284", "4285", "4108", "4160",
            "4163", "4191", "4193", "4195", "4196", "4197", "4161"
        ]
    },
    {
        "Taranaki", [
            "4322", "4353", "4398", "4399", "4610", "4614", "4640", "4671", "4672", "4673",
            "4674", "4675", "4678", "4679", "4679", "4330", "4347", "4386", "4387", "4387",
            "4388", "4389", "4390", "4390", "4642", "4612", "4641", "4376", "4310", "4312",
            "4340", "4341", "4343", "4344", "4351", "4360", "4361", "4362", "4371", "4372",
            "4373", "4374", "4381", "4381", "4314", "4345", "4335", "4348", "4616", "4645",
            "4649", "4681", "4682", "4684", "4685", "4520", "4545", "4597", "4598", "4332",
            "4352", "4390", "4391", "4391", "4392", "4393", "4393", "4394", "4394", "4395",
            "4396", "4397", "4397", "4349", "4375", "4377", "4378", "4379", "4320", "4346",
            "4382", "4383", "4549", "4510", "4544", "4591", "4592", "4578", "4587", "4588"
        ]
    },
    {
        "Manawatu-Wanganui", [
            "4771", "3979", "4810", "4847", "4884", "4816", "4818", "4863", "4894", "4867",
            "4930", "4942", "4970", "4971", "4972", "4973", "4975", "4976", "4977", "4978",
            "4979", "4900", "4940", "4993", "4994", "4995", "4996", "4702", "4740", "4743",
            "4775", "4775", "4777", "4779", "4814", "4815", "4848", "4849", "4891", "4891",
            "4893", "4845", "4730", "4745", "4781", "4782", "4783", "4783", "4784", "4785",
            "4786", "4744", "4774", "4774", "5510", "5540", "5570", "5571", "5572", "5573",
            "5574", "5575", "5541", "4746", "4797", "4797", "4710", "4741", "4787", "4788",
            "4789", "5881", "5882", "3995", "3951", "3948", "4943", "4974", "4625", "4660",
            "4691", "3926", "3947", "3980", "3980", "3997", "5583", "3989", "3990", "4910",
            "4941", "4981", "4982", "4983", "4984", "4985", "4986", "4987", "4988", "4989",
            "4410", "4412", "4412", "4414", "4440", "4441", "4442", "4443", "4444", "4445",
            "4446", "4447", "4448", "4470", "4470", "4471", "4471", "4472", "4473", "4474",
            "4474", "4475", "4475", "4476", "4477", "4477", "4477", "4478", "4478", "4479",
            "4481", "4481", "4779", "4820", "4866", "4944", "4990", "4991", "4992", "4632",
            "4646", "4694", "4696", "4548", "4780", "4865", "4817", "4862", "4821", "4860",
            "4392", "4396", "4397", "4720", "4742", "4791", "4791", "4792", "4793", "4794",
            "4795", "4795", "4796", "4287", "4822", "3920", "3924", "3946", "3991", "3992",
            "3993", "3994", "3996", "3987", "3987", "4864", "4547", "3998", "4825", "4826",
            "4861", "4500", "4501", "4541", "4542", "4543", "4571", "4572", "4573", "4573",
            "4574", "4575", "4576", "4576", "4577", "4577", "4578", "4581", "4581", "4582",
            "4584", "4585", "4586", "4587", "4920", "4945", "4997", "4998", "4999"
        ]
    },
    {
        "Bay of Plenty", [
            "3120", "3160", "3129", "3166", "3170", "3177", "3178", "3181", "3127", "3169",
            "3020", "3049", "3168", "3116", "3118", "3149", "3150", "3152", "3025", "3062",
            "3079", "3121", "3161", "3114", "3154", "3122", "3162", "3197", "3198", "3198",
            "3199", "3118", "3151", "3081", "3010", "3015", "3040", "3041", "3042", "3043",
            "3044", "3045", "3046", "3047", "3048", "3072", "3073", "3074", "3074", "3076",
            "3077", "3096", "3097", "3123", "3163", "3379", "3110", "3112", "3141", "3142",
            "3143", "3144", "3145", "3146", "3147", "3148", "3155", "3156", "3171", "3171",
            "3172", "3173", "3173", "3174", "3175", "3175", "3176", "3176", "3179", "3180",
            "3119", "3153", "3182", "3183", "3186", "3186", "3187", "3187", "3188", "3189",
            "3167", "3681", "3682", "3611", "3642", "3164", "3196", "3120", "3158", "3159",
            "3191", "3192", "3192", "3193", "3194", "3194", "3194"
        ]
    },
    {
        "Waikato", [
            "3979", "3078", "3078", "3078", "3944", "2675", "3432", "3434", "3450", "3493",
            "3493", "3494", "3494", "3495", "3496", "3496", "3547", "3506", "3543", "3581",
            "3582", "3583", "3584", "3584", "3264", "3200", "3204", "3204", "3206", "3206",
            "3210", "3210", "3214", "3216", "3218", "3240", "3241", "3242", "3243", "3244",
            "3245", "3247", "3248", "3251", "3252", "3253", "3254", "3255", "3256", "3257",
            "3263", "3281", "3281", "3282", "3282", "3283", "3283", "3284", "3285", "3285",
            "3286", "3286", "3287", "3288", "3288", "3289", "3289", "3290", "3290", "3290",
            "3293", "3451", "3579", "3262", "3700", "3740", "3771", "3772", "3843", "3889",
            "3945", "3978", "3020", "3421", "3445", "3492", "3492", "3492", "3400", "3440",
            "3471", "3472", "3473", "3473", "3260", "2474", "2441", "4350", "4376", "3300",
            "3340", "3371", "3371", "3372", "3372", "3373", "3373", "3373", "3374", "3375",
            "3375", "3720", "3742", "3793", "3794", "3503", "3541", "3597", "3803", "3881",
            "3882", "3883", "3784", "3784", "3885", "3886", "3886", "3900", "3940", "3972",
            "3973", "3974", "3975", "3975", "3976", "3976", "3977", "3977", "3600", "3640",
            "3671", "3672", "3673", "3673", "3674", "3674", "2583", "3546", "3912", "3942",
            "3970", "3971", "3802", "3844", "2402", "2440", "2471", "2471", "2472", "2473",
            "2473", "3880", "3880", "3880", "2120", "2677", "2678", "3411", "3415", "3443",
            "3481", "3482", "3483", "3225", "3265", "3295", "3296", "3297", "3060", "3081",
            "3081", "3083", "3083", "3072", "3072", "3073", "3077", "3508", "3544", "3721",
            "3791", "3792", "3330", "3332", "3350", "3351", "3352", "3377", "3378", "3379",
            "3384", "3385", "3320", "3342", "3391", "3392", "3392", "3393", "3800", "3840",
            "3841", "3872", "3873", "3873", "3874", "3874", "3875", "3876", "3876", "3877",
            "3877", "3878", "3879", "3710", "3741", "3781", "3782", "3910", "3941", "3981",
            "3982", "3982", "3983", "3985", "3986", "3986", "3987", "3988", "3894", "3895",
            "3266", "3500", "3540", "3574", "3575", "3576", "3577", "3578", "3410", "3442",
            "3484", "3484", "3485", "3485", "3420", "3444", "3491", "2121", "2342", "2693",
            "2694", "2695", "2696", "2697", "3334", "3353", "3381", "3382", "3545", "3391",
            "3401", "3441", "3474", "3610", "3641", "3681", "3682", "3310", "3341", "3380",
            "3943", "2681", "2682", "2683", "3475", "3620", "3643", "3691", "3691", "3261",
            "3646", "3510", "3542", "3591", "3592"
        ]
    },
    {
        "Auckland", [
            "792", "793", "794", "600", "602", "604", "610", "612", "614", "616", "618", "620", "622", "624",
            "626", "627", "629",
            "630", "632", "640", "641", "642", "643", "644", "645", "650", "651", "652", "653", "654", "655",
            "656", "657", "660",
            "661", "662", "664", "740", "741", "742", "743", "744", "745", "746", "747", "748", "749", "750",
            "751", "752", "753",
            "754", "755", "756", "757", "758", "760", "814", "816", "1010", "1011", "1021", "1022", "1023",
            "1024", "1025", "1026",
            "1041", "1042", "1050", "1051", "1052", "1060", "1061", "1062", "1071", "1072", "1140", "1142",
            "1143", "1144", "1146",
            "1147", "1148", "1149", "1150", "1151", "1245", "1246", "1342", "1344", "1345", "1348", "1349",
            "1350", "1351", "1352",
            "1440", "1443", "1445", "1446", "1541", "1542", "1545", "1546", "1640", "1642", "1643", "1644",
            "1740", "1741", "1742",
            "1743", "1745", "1746", "2010", "2012", "2013", "2014", "2016", "2018", "2019", "2022", "2023",
            "2024", "2025", "2102",
            "2103", "2104", "2105", "2140", "2143", "2144", "2145", "2146", "2147", "2148", "2150", "2151",
            "2153", "2154", "2155",
            "2156", "2158", "2159", "2160", "2161", "2163", "2164", "2241", "2242", "2243", "2343", "2675",
            "2122", "2248", "632",
            "2113", "2247", "2577", "2578", "2579", "960", "961", "962", "963", "991", "800", "840", "874",
            "875", "781", "782",
            "2571", "2254", "843", "871", "873", "810", "841", "891", "892", "947", "2576", "948", "772",
            "2252", "931", "946",
            "2110", "2112", "2113", "2166", "2244", "2580", "2582", "2583", "2584", "2585", "830", "844",
            "2344", "646", "2471",
            "2472", "951", "2120", "2340", "2676", "2677", "2678", "2679", "932", "945", "820", "932", "944",
            "950", "992", "993",
            "994", "920", "942", "2105", "2110", "2112", "2245", "2246", "2345", "1081", "1840", "1841", "1842",
            "1843", "1971",
            "812", "842", "881", "882", "883", "2123", "2341", "2681", "2682", "2683", "2684", "910", "920",
            "941", "981", "982",
            "983", "984", "985", "986", "900", "940", "972", "973", "974", "975", "977", "930", "932", "943",
            "952", "2019", "2149"
        ]
    },
    {
        "Northland", [
            "449", "451", "486", "462", "496", "420", "420", "310", "340", "370", "371", "372", "372", "373",
            "374", "376", "377",
            "379", "204", "114", "150", "181", "182", "182", "184", "184", "460", "448", "478", "479", "405",
            "440", "472", "473",
            "474", "474", "474", "410", "441", "481", "482", "483", "484", "542", "573", "185", "210", "243",
            "281", "282", "283",
            "230", "245", "293", "294", "295", "453", "491", "492", "505", "540", "541", "420", "442", "494",
            "593", "594", "146",
            "152", "520", "547", "583", "587", "588", "589", "211", "244", "154", "447", "475", "476", "444",
            "118", "192", "445",
            "200", "241", "200", "204", "247", "543", "571", "443", "116", "151", "530", "549", "591", "592",
            "202", "242", "272",
            "420", "450", "381", "341", "391", "153", "7173", "446", "193", "193", "230", "246", "510", "545",
            "582", "975", "110",
            "112", "118", "140", "141", "142", "143", "144", "145", "147", "148", "170", "171", "172", "172",
            "173", "174", "175",
            "176", "178", "178", "179"
        ]
    },
    {
        "Gisborne",
        [
            "4010", "4040", "4041", "4050", "4051", "4052", "4053", "4054", "4060",
            "4071", "4072", "4073", "4075", "4077", "4078", "4079", "4081", "4082",
            "4083", "4086", "4087", "4091", "4092", "4093", "4094", "4095", "4096",
            "4097", "4098", "4099", "4042", "4043", "4044", "4045", "4046", "4047",
            "4048", "4049"
        ]
    },
    {
        "Chatham Islands",
        [
            "8942", "8944"
        ]
    }
};

// Data is based from this website: https://sapling.co.nz/resources/new-zealand-rural-postcode-list/
string[] ruralPostcodes =
[
    "0792", "0793", "0794", "4771", "3979", "4884", "3078", "0486", "2675", "0496", "4894", "3493", "3494",
    "3495", "3496", "5791", "5792", "3581", "3582", "3583", "3584", "4971", "4972", "4973", "4975", "4976",
    "4977", "4978", "4970", "4979", "0371", "0372", "0373", "0374", "0376", "0377", "0370", "0379", "2577",
    "2578", "2579", "4994", "4996", "4993", "4995", "4398", "4399", "5771", "5772", "5773", "4775", "4777",
    "4779", "4891", "4893", "4071", "4072", "4073", "0991", "5794", "3281", "3282", "3283", "3284", "3285",
    "3286", "3287", "3288", "3289", "3290", "3293", "4171", "4172", "4174", "4175", "4179", "4180", "4178",
    "4294", "4295", "4671", "4672", "4673", "4674", "4675", "4678", "4679", "0874", "0875", "0781", "0782",
    "3579", "0181", "0182", "0184", "2571", "4781", "4782", "4783", "4784", "4785", "4786", "3771", "3772",
    "4386", "4387", "4388", "4389", "4390", "0478", "0479", "0474", "0472", "0473", "0481", "0482", "0483",
    "0484", "0573", "0185", "6972", "3177", "3178", "3170", "3181", "0871", "0873", "0281", "0282", "0283",
    "3889", "0294", "0295", "0293", "4774", "0491", "0492", "4188", "0891", "0892", "5571", "5574", "5575",
    "5572", "5570", "5573", "3978", "3492", "4797", "0494", "2576", "4078", "4787", "4788", "4789", "5881",
    "5882", "5883", "5884", "5885", "5886", "5887", "5888", "5889", "5890", "5871", "5872", "0593", "0594",
    "3471", "3472", "3473", "4075", "3995", "0583", "0587", "0588", "0589", "2474", "4376", "3371", "3372",
    "3373", "3374", "3375", "3079", "4181", "4182", "4183", "4184", "4186", "0772", "4371", "4372", "4373",
    "4374", "4381", "3793", "3794", "3597", "4974", "4198", "4691", "3881", "3882", "3883", "3784", "3980",
    "0475", "0476", "0192", "4278", "4279", "3997", "3885", "3886", "3197", "3198", "3199", "4681", "4682",
    "4684", "4685", "5581", "5582", "5583", "4276", "4277", "3972", "3973", "3974", "3975", "3976", "3977",
    "3989", "3990", "3671", "3672", "3673", "3674", "4981", "4982", "4983", "4984", "4985", "4986", "4987",
    "4988", "4989", "4471", "4472", "4473", "4474", "4475", "4476", "4477", "4478", "4479", "4470", "4481",
    "2580", "2582", "2583", "2584", "2585", "0571", "4597", "4598", "3971", "3970", "2471", "2472", "2473",
    "4990", "4991", "4992", "4291", "4292", "4293", "5381", "3880", "2676", "2677", "2678", "2679", "3481",
    "3482", "3483", "4694", "4696", "3295", "3296", "3297", "4189", "3081", "3083", "4780", "3077", "3072",
    "3073", "3074", "3076", "3096", "3097", "4081", "4082", "4083", "0591", "0592", "0272", "0994", "0992",
    "0993", "4391", "4392", "4393", "4394", "4395", "4396", "4397", "4791", "4792", "4793", "4794", "4795",
    "4796", "4286", "4287", "4288", "0381", "3991", "3992", "3993", "3994", "3996", "3791", "3792", "3377",
    "3378", "3379", "3384", "3385", "3171", "3172", "3173", "3174", "3175", "3176", "3179", "3180", "3391",
    "3392", "3393", "3879", "3872", "3873", "3874", "3875", "3876", "3877", "3878", "4091", "4092", "4093",
    "4094", "3781", "3782", "0391", "3981", "3982", "3983", "3985", "3986", "3987", "3988", "3894", "3895",
    "3182", "3183", "3186", "3187", "3188", "3189", "3578", "3577", "3574", "3575", "3576", "4087", "4086",
    "5894", "3484", "3485", "4079", "3491", "4077", "2696", "2697", "2693", "2694", "2695", "3381", "3382",
    "5371", "5372", "4377", "4375", "4379", "4378", "3474", "1971", "3681", "3682", "5391", "3196", "0881",
    "0882", "0883", "3998", "5373", "0193", "4271", "4272", "4273", "4274", "4275", "0582", "4281", "4282",
    "4283", "4284", "4285", "4191", "4197", "4193", "4195", "4196", "4382", "4383", "3380", "2681", "2682",
    "2683", "2684", "3475", "4571", "4572", "4573", "4574", "4575", "4576", "4577", "4578", "4581", "4582",
    "4584", "4585", "4586", "4587", "4588", "0981", "0982", "0983", "0984", "0985", "0986", "4591", "4592",
    "0972", "0973", "0974", "0975", "0977", "3191", "3192", "3193", "3194", "3691", "0171", "0172", "0173",
    "0174", "0175", "0176", "0178", "0179", "0170", "3591", "3592", "4997", "4998", "4999", "7581", "7582",
    "7583", "9391", "9392", "9393", "7481", "7482", "7483", "7771", "7772", "7773", "7774", "7775", "7776",
    "7777", "7778", "9271", "9272", "9273", "9274", "9779", "7670", "7871", "7271", "7272", "7273", "7274",
    "7275", "7276", "9091", "7091", "7984", "7381", "7382", "7383", "7384", "7671", "7672", "7674", "7675",
    "7676", "7677", "7678", "9583", "9584", "7673", "7073", "9384", "9383", "7391", "7392", "7571", "7572",
    "9791", "7872", "9076", "9077", "7987", "7193", "7991", "7992", "9372", "9771", "9772", "9773", "9774",
    "9775", "9776", "9777", "7387", "7884", "7178", "7385", "7881", "7882", "7883", "9871", "9872", "9874",
    "9875", "9876", "9879", "9877", "7691", "7692", "7371", "7374", "7373", "9281", "9282", "7893", "7875",
    "9498", "9591", "9593", "7682", "7683", "7591", "9792", "9793", "9794", "8971", "5781", "5782", "5783",
    "5784", "7791", "9596", "9597", "9598", "9291", "9292", "9092", "7196", "7197", "7198", "7077", "7071",
    "7072", "9491", "9492", "9494", "9495", "9493", "9376", "9377", "9689", "9682", "9683", "9386", "9387",
    "9073", "9074", "9585", "9586", "7495", "9481", "9482", "9483", "7990", "7281", "7282", "7284", "7982",
    "7983", "9081", "9082", "9371", "7194", "7192", "7195", "7781", "7782", "7783", "7784", "9395", "9396",
    "9397", "9398", "7471", "7472", "7473", "7475", "7476", "7477", "7895", "7081", "9881", "9883", "7885",
    "7379", "9571", "9572", "7873", "7285", "7580", "7681", "7988", "7183", "7182", "9587", "9679", "9672",
    "7985", "7986", "7971", "7972", "7973", "7974", "7975", "9884", "9691", "7173", "7175", "7395", "9778",
    "7491", "9471", "9472", "7977", "7978", "7979", "7980", "9085", "7095", "7096", "9382", "7891", "7892",
    "7886", "9781", "9782", "9783", "9891", "9892", "9893"
];

foreach (var kvp in nzRegionalPostCodes.OrderBy(p => p.Key))
{
    var currentList = kvp.Value.Select(code => code.Trim().PadLeft(4, '0')).ToArray();
    var urbanPostCodes = currentList.Except(ruralPostcodes).ToList();
    Console.WriteLine($"{kvp.Key} Urban postcodes: ");
    Console.WriteLine(string.Join(",", urbanPostCodes));
    Console.WriteLine($"{kvp.Key} Rural postcodes: ");
    Console.WriteLine(string.Join(",", currentList.Except(urbanPostCodes)));
    Console.WriteLine();
}