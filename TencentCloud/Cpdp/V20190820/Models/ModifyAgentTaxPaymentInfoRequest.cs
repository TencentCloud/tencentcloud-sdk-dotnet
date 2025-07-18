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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAgentTaxPaymentInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// 批次号
        /// </summary>
        [JsonProperty("BatchNum")]
        public long? BatchNum{ get; set; }

        /// <summary>
        /// 新源电子凭证地址
        /// </summary>
        [JsonProperty("RawElectronicCertUrl")]
        public string RawElectronicCertUrl{ get; set; }

        /// <summary>
        /// 新的文件名
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// 接入环境。沙箱环境填sandbox
        /// </summary>
        [JsonProperty("Profile")]
        public string Profile{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BatchNum", this.BatchNum);
            this.SetParamSimple(map, prefix + "RawElectronicCertUrl", this.RawElectronicCertUrl);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "Profile", this.Profile);
        }
    }
}

