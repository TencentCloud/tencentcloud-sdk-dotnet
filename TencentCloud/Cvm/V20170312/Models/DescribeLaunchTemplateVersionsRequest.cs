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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeLaunchTemplateVersionsRequest : AbstractModel
    {
        
        /// <summary>
        /// 启动模板ID。
        /// </summary>
        [JsonProperty("LaunchTemplateId")]
        public string LaunchTemplateId{ get; set; }

        /// <summary>
        /// 实例启动模板列表。
        /// </summary>
        [JsonProperty("LaunchTemplateVersions")]
        public ulong?[] LaunchTemplateVersions{ get; set; }

        /// <summary>
        /// 通过范围指定版本时的最小版本号，默认为0。
        /// </summary>
        [JsonProperty("MinVersion")]
        public ulong? MinVersion{ get; set; }

        /// <summary>
        /// 过范围指定版本时的最大版本号，默认为30。
        /// </summary>
        [JsonProperty("MaxVersion")]
        public ulong? MaxVersion{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。关于`Offset`的更进一步介绍请参考 API [简介](https://cloud.tencent.com/document/api/213/15688)中的相关小节。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 返回数量，默认为20，最大值为100。关于`Limit`的更进一步介绍请参考 API [简介](https://cloud.tencent.com/document/api/213/15688)中的相关小节。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 是否查询默认版本。该参数不可与LaunchTemplateVersions同时指定。
        /// </summary>
        [JsonProperty("DefaultVersion")]
        public bool? DefaultVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LaunchTemplateId", this.LaunchTemplateId);
            this.SetParamArraySimple(map, prefix + "LaunchTemplateVersions.", this.LaunchTemplateVersions);
            this.SetParamSimple(map, prefix + "MinVersion", this.MinVersion);
            this.SetParamSimple(map, prefix + "MaxVersion", this.MaxVersion);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "DefaultVersion", this.DefaultVersion);
        }
    }
}

