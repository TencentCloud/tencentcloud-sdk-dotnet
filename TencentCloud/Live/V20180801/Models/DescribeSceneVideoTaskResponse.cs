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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSceneVideoTaskResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>一些特殊场景的返回信息。</p>
        /// </summary>
        [JsonProperty("InfoList")]
        public SceneVideoOutputInfo[] InfoList{ get; set; }

        /// <summary>
        /// <p>任务状态。</p><p>枚举值：</p><ul><li>DONE： 任务结束。</li><li>RUN： 任务运行中。</li><li>WAIT： 任务准备中。</li><li>FAIL： 任务失败。</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>输出视频的分辨率。示例：720x1280。</p>
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }

        /// <summary>
        /// <p>错误信息。</p>
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// <p>输出的视频Url。默认过期时间:12小时，请尽快拉取并转存。也可以使用私有Cos桶长期存储。</p>
        /// </summary>
        [JsonProperty("VideoUrls")]
        public string[] VideoUrls{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "InfoList.", this.InfoList);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamArraySimple(map, prefix + "VideoUrls.", this.VideoUrls);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

