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

    public class CreateBPFakeURLRequest : AbstractModel
    {
        
        /// <summary>
        /// 企业id
        /// </summary>
        [JsonProperty("CompanyId")]
        public long? CompanyId{ get; set; }

        /// <summary>
        /// 仿冒网址
        /// </summary>
        [JsonProperty("FakeURL")]
        public string FakeURL{ get; set; }

        /// <summary>
        /// 仿冒网址截图
        /// </summary>
        [JsonProperty("FakeURLSnapshots")]
        public string[] FakeURLSnapshots{ get; set; }

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
            this.SetParamSimple(map, prefix + "FakeURL", this.FakeURL);
            this.SetParamArraySimple(map, prefix + "FakeURLSnapshots.", this.FakeURLSnapshots);
            this.SetParamSimple(map, prefix + "Note", this.Note);
        }
    }
}

