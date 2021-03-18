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

namespace TencentCloud.Iotvideoindustry.V20201201.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ControlDevicePTZRequest : AbstractModel
    {
        
        /// <summary>
        /// 设备唯一标识
        /// </summary>
        [JsonProperty("DeviceId")]
        public string DeviceId{ get; set; }

        /// <summary>
        /// PTZ控制命令类型：
        /// stop - 停止当前PTZ信令
        /// left - 向左移动
        /// right - 向右移动
        /// up - 向上移动
        /// down - 向下移动
        /// leftUp - 左上移动
        /// leftDown - 左下移动
        /// rightUp - 右上移动
        /// rightDown - 右下移动
        /// zoomOut - 镜头缩小
        /// zoomIn - 镜头放大
        /// irisIn - 光圈缩小
        /// irisOut - 光圈放大
        /// focusIn - 焦距变近
        /// focusOut - 焦距变远
        /// </summary>
        [JsonProperty("Command")]
        public string Command{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
            this.SetParamSimple(map, prefix + "Command", this.Command);
        }
    }
}

