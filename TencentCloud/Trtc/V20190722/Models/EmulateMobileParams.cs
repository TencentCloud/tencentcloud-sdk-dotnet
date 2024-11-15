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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EmulateMobileParams : AbstractModel
    {
        
        /// <summary>
        /// 移动设备类型，
        /// 0: 手机
        /// 1: 平板
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MobileDeviceType")]
        public ulong? MobileDeviceType{ get; set; }

        /// <summary>
        /// 屏幕方向，
        /// 0: 竖屏，
        /// 1: 横屏
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScreenOrientation")]
        public ulong? ScreenOrientation{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MobileDeviceType", this.MobileDeviceType);
            this.SetParamSimple(map, prefix + "ScreenOrientation", this.ScreenOrientation);
        }
    }
}

