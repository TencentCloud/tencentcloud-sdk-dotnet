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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAigcUsageDataRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>起始日期。使用 <a href="https://cloud.tencent.com/document/product/266/11732#52">ISO 日期格式</a>。</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>结束日期，需大于等于起始日期。使用 <a href="https://cloud.tencent.com/document/product/266/11732#52">ISO 日期格式</a>。</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>AIGC类型。</p><p>枚举值：</p><ul><li>Video： 视频</li><li>Image： 图片</li><li>Text： 文本</li><li>SceneAigcVideo： 场景化视频处理</li><li>SceneAigcImage： 场景化图片处理</li><li>SceneAigcTime： 场景化处理次数</li></ul>
        /// </summary>
        [JsonProperty("AigcType")]
        public string AigcType{ get; set; }

        /// <summary>
        /// <p><b>点播<a href="/document/product/266/14574">应用</a> ID。从2023年12月25日起开通点播的客户，如访问点播应用中的资源（无论是默认应用还是新创建的应用），必须将该字段填写为应用 ID。</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "AigcType", this.AigcType);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
        }
    }
}

