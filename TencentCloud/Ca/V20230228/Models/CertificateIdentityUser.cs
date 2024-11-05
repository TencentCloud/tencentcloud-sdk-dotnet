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

namespace TencentCloud.Ca.V20230228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CertificateIdentityUser : AbstractModel
    {
        
        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 唯一身份id
        /// </summary>
        [JsonProperty("IdentityUniqueId")]
        public string IdentityUniqueId{ get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [JsonProperty("IdCardNumber")]
        public string IdCardNumber{ get; set; }

        /// <summary>
        /// 身份鉴别类型
        /// 1：授权金融机构身份鉴别
        /// </summary>
        [JsonProperty("IdentificationType")]
        public string IdentificationType{ get; set; }

        /// <summary>
        /// 身份鉴别措施
        /// 1、身份证鉴别
        /// 2、银行卡鉴别
        /// 3、支付账户密码验证
        /// 4、人脸识别验证
        /// </summary>
        [JsonProperty("IdentificationMeasures")]
        public string[] IdentificationMeasures{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "IdentityUniqueId", this.IdentityUniqueId);
            this.SetParamSimple(map, prefix + "IdCardNumber", this.IdCardNumber);
            this.SetParamSimple(map, prefix + "IdentificationType", this.IdentificationType);
            this.SetParamArraySimple(map, prefix + "IdentificationMeasures.", this.IdentificationMeasures);
        }
    }
}

