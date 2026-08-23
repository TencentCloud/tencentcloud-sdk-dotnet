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

    public class ImageScanAssetTarget : AbstractModel
    {
        
        /// <summary>
        /// <p>目标镜像匹配模式</p><p>枚举值：</p><ul><li>ALL： 全部镜像</li><li>MANUAL： 手动选择</li><li>AUTO_MATCH： 自动匹配</li></ul>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// <p>全部镜像模式下扫描排除的镜像id</p>
        /// </summary>
        [JsonProperty("ExcludeImages")]
        public string[] ExcludeImages{ get; set; }

        /// <summary>
        /// <p>手动选择模式下需要扫描的镜像id</p>
        /// </summary>
        [JsonProperty("Images")]
        public string[] Images{ get; set; }

        /// <summary>
        /// <p>自动匹配模式下匹配配置</p>
        /// </summary>
        [JsonProperty("AutoMatch")]
        public ImageScanAutoMatchConfig AutoMatch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamArraySimple(map, prefix + "ExcludeImages.", this.ExcludeImages);
            this.SetParamArraySimple(map, prefix + "Images.", this.Images);
            this.SetParamObj(map, prefix + "AutoMatch.", this.AutoMatch);
        }
    }
}

