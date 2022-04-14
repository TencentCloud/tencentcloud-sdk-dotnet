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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCloudSubMerchantRequest : AbstractModel
    {
        
        /// <summary>
        /// 米大师分配的支付主MidasAppId，根应用Id。
        /// </summary>
        [JsonProperty("MidasAppId")]
        public string MidasAppId{ get; set; }

        /// <summary>
        /// 父应用Id。
        /// </summary>
        [JsonProperty("ParentAppId")]
        public string ParentAppId{ get; set; }

        /// <summary>
        /// 子商户名。
        /// </summary>
        [JsonProperty("SubMchName")]
        public string SubMchName{ get; set; }

        /// <summary>
        /// 子商户描述。
        /// </summary>
        [JsonProperty("SubMchDescription")]
        public string SubMchDescription{ get; set; }

        /// <summary>
        /// 环境类型
        /// __release__:生产环境
        /// __sandbox__:沙箱环境
        /// _不填默认为生产环境_
        /// </summary>
        [JsonProperty("MidasEnvironment")]
        public string MidasEnvironment{ get; set; }

        /// <summary>
        /// 子应用Id，为空则自动创建子应用id。
        /// </summary>
        [JsonProperty("SubAppId")]
        public string SubAppId{ get; set; }

        /// <summary>
        /// 子商户名缩写。
        /// </summary>
        [JsonProperty("SubMchShortName")]
        public string SubMchShortName{ get; set; }

        /// <summary>
        /// 业务平台自定义的子商户Id，唯一。
        /// </summary>
        [JsonProperty("OutSubMerchantId")]
        public string OutSubMerchantId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MidasAppId", this.MidasAppId);
            this.SetParamSimple(map, prefix + "ParentAppId", this.ParentAppId);
            this.SetParamSimple(map, prefix + "SubMchName", this.SubMchName);
            this.SetParamSimple(map, prefix + "SubMchDescription", this.SubMchDescription);
            this.SetParamSimple(map, prefix + "MidasEnvironment", this.MidasEnvironment);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "SubMchShortName", this.SubMchShortName);
            this.SetParamSimple(map, prefix + "OutSubMerchantId", this.OutSubMerchantId);
        }
    }
}

