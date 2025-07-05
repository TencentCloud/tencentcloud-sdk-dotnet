/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Essbasic.V20201222.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UserDescribe : AbstractModel
    {
        
        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 手机号，隐藏中间4位数字，用*代替
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }

        /// <summary>
        /// 注册时间点 (UNIX时间戳)
        /// </summary>
        [JsonProperty("CreatedOn")]
        public long? CreatedOn{ get; set; }

        /// <summary>
        /// 实名认证状态：
        /// 0 - 未实名；
        /// 1 - 通过实名
        /// </summary>
        [JsonProperty("VerifyStatus")]
        public long? VerifyStatus{ get; set; }

        /// <summary>
        /// 真实姓名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 实名认证通过时间 (UNIX时间戳)
        /// </summary>
        [JsonProperty("VerifiedOn")]
        public long? VerifiedOn{ get; set; }

        /// <summary>
        /// 身份证件类型; 
        /// ID_CARD - 居民身份证；
        /// PASSPORT - 护照；
        /// MAINLAND_TRAVEL_PERMIT_FOR_HONGKONG_AND_MACAO_RESIDENTS - 港澳居民来往内地通行证；
        /// MAINLAND_TRAVEL_PERMIT_FOR_TAIWAN_RESIDENTS - 台湾居民来往大陆通行证；
        /// HOUSEHOLD_REGISTER - 户口本；
        /// TEMP_ID_CARD - 临时居民身份证
        /// </summary>
        [JsonProperty("IdCardType")]
        public string IdCardType{ get; set; }

        /// <summary>
        /// 身份证件号码 (脱敏)
        /// </summary>
        [JsonProperty("IdCardNumber")]
        public string IdCardNumber{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamSimple(map, prefix + "VerifyStatus", this.VerifyStatus);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "VerifiedOn", this.VerifiedOn);
            this.SetParamSimple(map, prefix + "IdCardType", this.IdCardType);
            this.SetParamSimple(map, prefix + "IdCardNumber", this.IdCardNumber);
        }
    }
}

