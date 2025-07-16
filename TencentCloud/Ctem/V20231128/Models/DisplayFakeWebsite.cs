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

namespace TencentCloud.Ctem.V20231128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DisplayFakeWebsite : AbstractModel
    {
        
        /// <summary>
        /// 主键ID
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 公共字段
        /// </summary>
        [JsonProperty("DisplayToolCommon")]
        public DisplayToolCommon DisplayToolCommon{ get; set; }

        /// <summary>
        /// 仿冒网站
        /// </summary>
        [JsonProperty("Website")]
        public string Website{ get; set; }

        /// <summary>
        /// ip位置
        /// </summary>
        [JsonProperty("IPLocation")]
        public string IPLocation{ get; set; }

        /// <summary>
        /// 截图
        /// </summary>
        [JsonProperty("Screenshot")]
        public string Screenshot{ get; set; }

        /// <summary>
        /// 处置状态：0-待处理 1-处理中 2-已处理
        /// </summary>
        [JsonProperty("HandlingStatus")]
        public long? HandlingStatus{ get; set; }

        /// <summary>
        /// 关停状态：0-(默认状态) 1-关停审核中 2-已拦截 3-已拒绝 4-下线流程中 5-已下线 6-下线失败
        /// </summary>
        [JsonProperty("ShutdownStatus")]
        public long? ShutdownStatus{ get; set; }

        /// <summary>
        /// 关停时间
        /// </summary>
        [JsonProperty("ShutdownTime")]
        public string ShutdownTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamObj(map, prefix + "DisplayToolCommon.", this.DisplayToolCommon);
            this.SetParamSimple(map, prefix + "Website", this.Website);
            this.SetParamSimple(map, prefix + "IPLocation", this.IPLocation);
            this.SetParamSimple(map, prefix + "Screenshot", this.Screenshot);
            this.SetParamSimple(map, prefix + "HandlingStatus", this.HandlingStatus);
            this.SetParamSimple(map, prefix + "ShutdownStatus", this.ShutdownStatus);
            this.SetParamSimple(map, prefix + "ShutdownTime", this.ShutdownTime);
        }
    }
}

