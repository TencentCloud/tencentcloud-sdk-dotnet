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

namespace TencentCloud.Weilingwith.V20230427.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ControlCameraPTZRequest : AbstractModel
    {
        
        /// <summary>
        /// 设备的唯一标识
        /// </summary>
        [JsonProperty("WID")]
        public string WID{ get; set; }

        /// <summary>
        /// ptz指令
        /// left - 向左移动
        /// right - 向右移动
        /// up - 向上移动
        /// down - 向下
        /// zoomOut - 镜头缩小
        /// zoomIn - 镜头放大
        /// irisIn - 光圈缩小
        /// irisOut - 光圈放大
        /// focusIn - 焦距变近
        /// focusOut - 焦距变远
        /// </summary>
        [JsonProperty("CMD")]
        public string CMD{ get; set; }

        /// <summary>
        /// 工作空间Id
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public long? WorkspaceId{ get; set; }

        /// <summary>
        /// 应用token
        /// </summary>
        [JsonProperty("ApplicationToken")]
        public string ApplicationToken{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WID", this.WID);
            this.SetParamSimple(map, prefix + "CMD", this.CMD);
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "ApplicationToken", this.ApplicationToken);
        }
    }
}

