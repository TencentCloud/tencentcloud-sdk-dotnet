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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SourceLocationInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>ID，唯一标识。</p>
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// <p>SourceLocation名称。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>地域。</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>BaseUrl信息。</p>
        /// </summary>
        [JsonProperty("BaseUrl")]
        public string BaseUrl{ get; set; }

        /// <summary>
        /// <p>是否开启补片。</p>
        /// </summary>
        [JsonProperty("SegmentDeliverEnable")]
        public bool? SegmentDeliverEnable{ get; set; }

        /// <summary>
        /// <p>补片配置。</p>
        /// </summary>
        [JsonProperty("SegmentDeliverConf")]
        public SegmentDeliverInfo SegmentDeliverConf{ get; set; }

        /// <summary>
        /// <p>绑定的直播source id列表。</p>
        /// </summary>
        [JsonProperty("AttachedLiveSources")]
        public string[] AttachedLiveSources{ get; set; }

        /// <summary>
        /// <p>绑定的点播source id列表。</p>
        /// </summary>
        [JsonProperty("AttachedVodSources")]
        public string[] AttachedVodSources{ get; set; }

        /// <summary>
        /// <p>source location创建时间，Unix时间戳。</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// <p>source location最近一次修改时间，Unix时间戳。</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public ulong? UpdateTime{ get; set; }

        /// <summary>
        /// <p>是否开启package分发分片，默认开启。</p>
        /// </summary>
        [JsonProperty("SegmentDeliverUsePackageEnable")]
        public bool? SegmentDeliverUsePackageEnable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "BaseUrl", this.BaseUrl);
            this.SetParamSimple(map, prefix + "SegmentDeliverEnable", this.SegmentDeliverEnable);
            this.SetParamObj(map, prefix + "SegmentDeliverConf.", this.SegmentDeliverConf);
            this.SetParamArraySimple(map, prefix + "AttachedLiveSources.", this.AttachedLiveSources);
            this.SetParamArraySimple(map, prefix + "AttachedVodSources.", this.AttachedVodSources);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "SegmentDeliverUsePackageEnable", this.SegmentDeliverUsePackageEnable);
        }
    }
}

