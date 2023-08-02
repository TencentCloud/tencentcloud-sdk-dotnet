/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreatePersonAuthCertificateImageRequest : AbstractModel
    {
        
        /// <summary>
        /// 操作人信息
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 个人用户名称
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 身份证件类型取值：
        /// ID_CARD 身居民身份证
        /// PASSPORT 护照
        /// HONGKONG_AND_MACAO 港澳居民来往内地通行证
        /// FOREIGN_ID_CARD 外国人永久居留身份证
        /// HONGKONG_MACAO_AND_TAIWAN 港澳台居民居住证(格式同居民身份证)
        /// </summary>
        [JsonProperty("IdCardType")]
        public string IdCardType{ get; set; }

        /// <summary>
        /// 身份证件号码
        /// </summary>
        [JsonProperty("IdCardNumber")]
        public string IdCardNumber{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "IdCardType", this.IdCardType);
            this.SetParamSimple(map, prefix + "IdCardNumber", this.IdCardNumber);
        }
    }
}

