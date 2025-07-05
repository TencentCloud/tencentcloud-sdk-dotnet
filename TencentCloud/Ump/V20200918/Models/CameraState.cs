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

namespace TencentCloud.Ump.V20200918.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CameraState : AbstractModel
    {
        
        /// <summary>
        /// 相机ID
        /// </summary>
        [JsonProperty("CameraId")]
        public ulong? CameraId{ get; set; }

        /// <summary>
        /// 相机状态:
        /// 10: 初始化
        /// 11: 未知状态
        /// 12: 网络异常
        /// 13: 未授权
        /// 14: 相机App异常
        /// 15: 相机取流异常
        /// 16: 状态正常
        /// </summary>
        [JsonProperty("State")]
        public ulong? State{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CameraId", this.CameraId);
            this.SetParamSimple(map, prefix + "State", this.State);
        }
    }
}

