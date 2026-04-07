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

    public class OutputInfo : AbstractModel
    {
        
        /// <summary>
        /// HLS DASH。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// output group名称，可以和source的group名称对应关联起来。
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// channel program调度后输出的文件名。
        /// </summary>
        [JsonProperty("ManifestName")]
        public string ManifestName{ get; set; }

        /// <summary>
        /// Type为HLS时manifest配置使用的字段。
        /// </summary>
        [JsonProperty("ManifestConf")]
        public ManifestInfo ManifestConf{ get; set; }

        /// <summary>
        /// 播放地址。
        /// </summary>
        [JsonProperty("PlaybackURL")]
        public string PlaybackURL{ get; set; }

        /// <summary>
        /// Type为DASH时manifest配置使用的字段。
        /// </summary>
        [JsonProperty("DashManifestConf")]
        public DashManifestInfo DashManifestConf{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "ManifestName", this.ManifestName);
            this.SetParamObj(map, prefix + "ManifestConf.", this.ManifestConf);
            this.SetParamSimple(map, prefix + "PlaybackURL", this.PlaybackURL);
            this.SetParamObj(map, prefix + "DashManifestConf.", this.DashManifestConf);
        }
    }
}

