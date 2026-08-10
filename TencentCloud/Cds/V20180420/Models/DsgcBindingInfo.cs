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

namespace TencentCloud.Cds.V20180420.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DsgcBindingInfo : AbstractModel
    {
        
        /// <summary>
        /// dspa实例id
        /// </summary>
        [JsonProperty("DspaId")]
        public string DspaId{ get; set; }

        /// <summary>
        /// dspa绑定模板/合规组 id ComplianceGroupId
        /// </summary>
        [JsonProperty("DspaCgId")]
        public ulong? DspaCgId{ get; set; }

        /// <summary>
        /// dspa绑定模板/合规组名称
        /// </summary>
        [JsonProperty("DspaCgName")]
        public string DspaCgName{ get; set; }

        /// <summary>
        /// dspa实例状态 0 正常 1 隔离 2 销毁
        /// </summary>
        [JsonProperty("DspaStatus")]
        public ulong? DspaStatus{ get; set; }

        /// <summary>
        /// 模板状态 0: 正常   1: 已删除
        /// </summary>
        [JsonProperty("DspaCgStatus")]
        public ulong? DspaCgStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DspaId", this.DspaId);
            this.SetParamSimple(map, prefix + "DspaCgId", this.DspaCgId);
            this.SetParamSimple(map, prefix + "DspaCgName", this.DspaCgName);
            this.SetParamSimple(map, prefix + "DspaStatus", this.DspaStatus);
            this.SetParamSimple(map, prefix + "DspaCgStatus", this.DspaCgStatus);
        }
    }
}

