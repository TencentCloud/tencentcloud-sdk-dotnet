/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SpeedTestingConfig : AbstractModel
    {
        
        /// <summary>
        /// 任务类型，取值有：
        /// <li>1：页面性能;</li>
        /// <li>2：文件上传;</li>
        /// <li>3：文件下载;</li>
        /// <li>4：端口性能;</li>
        /// <li>5：网络质量;</li>
        /// <li>6：音视频体验。</li>
        /// </summary>
        [JsonProperty("TaskType")]
        public long? TaskType{ get; set; }

        /// <summary>
        /// 拨测 url。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 拨测 UA。
        /// </summary>
        [JsonProperty("UA")]
        public string UA{ get; set; }

        /// <summary>
        /// 网络类型。
        /// </summary>
        [JsonProperty("Connectivity")]
        public string Connectivity{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "UA", this.UA);
            this.SetParamSimple(map, prefix + "Connectivity", this.Connectivity);
        }
    }
}

