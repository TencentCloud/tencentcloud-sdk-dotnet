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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePatchInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// kb编号
        /// </summary>
        [JsonProperty("KbNo")]
        public string KbNo{ get; set; }

        /// <summary>
        /// kb名称
        /// </summary>
        [JsonProperty("PatchName")]
        public string PatchName{ get; set; }

        /// <summary>
        /// kb 发布日期
        /// </summary>
        [JsonProperty("PublishTime")]
        public string PublishTime{ get; set; }

        /// <summary>
        /// 参考链接
        /// </summary>
        [JsonProperty("ReferUrl")]
        public string ReferUrl{ get; set; }

        /// <summary>
        /// 包含漏洞数
        /// </summary>
        [JsonProperty("VulCount")]
        public ulong? VulCount{ get; set; }

        /// <summary>
        /// 补丁关联的漏洞详情列表
        /// </summary>
        [JsonProperty("RelateVulInfoList")]
        public RelateVulInfo[] RelateVulInfoList{ get; set; }

        /// <summary>
        /// 补丁id
        /// </summary>
        [JsonProperty("KbId")]
        public ulong? KbId{ get; set; }

        /// <summary>
        /// 关联的漏洞CveId，多个id由","分隔
        /// </summary>
        [JsonProperty("RelateVulCveId")]
        public string RelateVulCveId{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KbNo", this.KbNo);
            this.SetParamSimple(map, prefix + "PatchName", this.PatchName);
            this.SetParamSimple(map, prefix + "PublishTime", this.PublishTime);
            this.SetParamSimple(map, prefix + "ReferUrl", this.ReferUrl);
            this.SetParamSimple(map, prefix + "VulCount", this.VulCount);
            this.SetParamArrayObj(map, prefix + "RelateVulInfoList.", this.RelateVulInfoList);
            this.SetParamSimple(map, prefix + "KbId", this.KbId);
            this.SetParamSimple(map, prefix + "RelateVulCveId", this.RelateVulCveId);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

