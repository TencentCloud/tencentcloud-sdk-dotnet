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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageLayer : AbstractModel
    {
        
        /// <summary>
        /// <p>镜像层序号</p>
        /// </summary>
        [JsonProperty("LayerIndex")]
        public ulong? LayerIndex{ get; set; }

        /// <summary>
        /// <p>镜像层id</p>
        /// </summary>
        [JsonProperty("LayerId")]
        public string LayerId{ get; set; }

        /// <summary>
        /// <p>镜像层命令行</p>
        /// </summary>
        [JsonProperty("LayerCmd")]
        public string LayerCmd{ get; set; }

        /// <summary>
        /// <p>镜像层大小</p>
        /// </summary>
        [JsonProperty("Size")]
        public ulong? Size{ get; set; }

        /// <summary>
        /// <p>严重漏洞数</p>
        /// </summary>
        [JsonProperty("CriticalLevelVulCnt")]
        public ulong? CriticalLevelVulCnt{ get; set; }

        /// <summary>
        /// <p>高危漏洞数</p>
        /// </summary>
        [JsonProperty("HighLevelVulCnt")]
        public ulong? HighLevelVulCnt{ get; set; }

        /// <summary>
        /// <p>中危漏洞数</p>
        /// </summary>
        [JsonProperty("MediumLevelVulCnt")]
        public ulong? MediumLevelVulCnt{ get; set; }

        /// <summary>
        /// <p>低危漏洞数</p>
        /// </summary>
        [JsonProperty("LowLevelVulCnt")]
        public ulong? LowLevelVulCnt{ get; set; }

        /// <summary>
        /// <p>木马数</p>
        /// </summary>
        [JsonProperty("VirusCnt")]
        public ulong? VirusCnt{ get; set; }

        /// <summary>
        /// <p>敏感信息数</p>
        /// </summary>
        [JsonProperty("SensitiveCnt")]
        public ulong? SensitiveCnt{ get; set; }

        /// <summary>
        /// <p>镜像层创建时间</p><p>参数格式：YYYY-MM-DD hh:mm:ss</p>
        /// </summary>
        [JsonProperty("LayerCreateTime")]
        public string LayerCreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LayerIndex", this.LayerIndex);
            this.SetParamSimple(map, prefix + "LayerId", this.LayerId);
            this.SetParamSimple(map, prefix + "LayerCmd", this.LayerCmd);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "CriticalLevelVulCnt", this.CriticalLevelVulCnt);
            this.SetParamSimple(map, prefix + "HighLevelVulCnt", this.HighLevelVulCnt);
            this.SetParamSimple(map, prefix + "MediumLevelVulCnt", this.MediumLevelVulCnt);
            this.SetParamSimple(map, prefix + "LowLevelVulCnt", this.LowLevelVulCnt);
            this.SetParamSimple(map, prefix + "VirusCnt", this.VirusCnt);
            this.SetParamSimple(map, prefix + "SensitiveCnt", this.SensitiveCnt);
            this.SetParamSimple(map, prefix + "LayerCreateTime", this.LayerCreateTime);
        }
    }
}

