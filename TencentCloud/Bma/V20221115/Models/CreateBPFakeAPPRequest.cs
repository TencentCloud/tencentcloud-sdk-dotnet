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

namespace TencentCloud.Bma.V20221115.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateBPFakeAPPRequest : AbstractModel
    {
        
        /// <summary>
        /// 企业id
        /// </summary>
        [JsonProperty("CompanyId")]
        public long? CompanyId{ get; set; }

        /// <summary>
        /// 仿冒应用名称
        /// </summary>
        [JsonProperty("FakeAPPName")]
        public string FakeAPPName{ get; set; }

        /// <summary>
        /// 仿冒来源
        /// </summary>
        [JsonProperty("APPChan")]
        public string APPChan{ get; set; }

        /// <summary>
        /// 仿冒应用包名
        /// </summary>
        [JsonProperty("FakeAPPPackageName")]
        public string FakeAPPPackageName{ get; set; }

        /// <summary>
        /// 仿冒应用证书
        /// </summary>
        [JsonProperty("FakeAPPCert")]
        public string FakeAPPCert{ get; set; }

        /// <summary>
        /// 仿冒应用大小
        /// </summary>
        [JsonProperty("FakeAPPSize")]
        public string FakeAPPSize{ get; set; }

        /// <summary>
        /// 仿冒截图
        /// </summary>
        [JsonProperty("FakeAPPSnapshots")]
        public string[] FakeAPPSnapshots{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Note")]
        public string Note{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CompanyId", this.CompanyId);
            this.SetParamSimple(map, prefix + "FakeAPPName", this.FakeAPPName);
            this.SetParamSimple(map, prefix + "APPChan", this.APPChan);
            this.SetParamSimple(map, prefix + "FakeAPPPackageName", this.FakeAPPPackageName);
            this.SetParamSimple(map, prefix + "FakeAPPCert", this.FakeAPPCert);
            this.SetParamSimple(map, prefix + "FakeAPPSize", this.FakeAPPSize);
            this.SetParamArraySimple(map, prefix + "FakeAPPSnapshots.", this.FakeAPPSnapshots);
            this.SetParamSimple(map, prefix + "Note", this.Note);
        }
    }
}

