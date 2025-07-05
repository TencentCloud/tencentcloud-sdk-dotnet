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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetFaceIdRiskInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 描述当前请求所在设备的风险标签
        /// - 详情如下：
        /// 01-设备疑似被Root/设备疑似越狱。
        /// 02-设备疑似被注入。
        /// 03-设备疑似为模拟器。
        /// 04-设备疑似存在风险操作。
        /// 05-摄像头疑似被劫持。
        /// 06-疑似黑产设备。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeviceInfoTag")]
        public string DeviceInfoTag{ get; set; }

        /// <summary>
        /// 描述当前请求所在设备的风险等级，共4级。
        /// - 详情如下：
        ///  1 - 低风险。
        ///  2 - 中风险。
        ///  3 - 高风险。
        ///  4 - 攻击。 
        /// -1表示未获取到风险等级。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeviceInfoLevel")]
        public long? DeviceInfoLevel{ get; set; }

        /// <summary>
        /// 设备id标识。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OpenId")]
        public string OpenId{ get; set; }

        /// <summary>
        /// 描述当前请求所在设备的相机指纹风险等级，共4级。
        /// - 详情如下：
        ///  1 - 低风险。
        ///  2 - 中风险。
        ///  3 - 高风险。
        ///  4 - 攻击。
        ///  -1表示未获取到风险等级。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CameraInfoLevel")]
        public long? CameraInfoLevel{ get; set; }

        /// <summary>
        /// 描述当前请求所在设备的相机指纹风险标签。
        /// 
        /// - 详情如下：
        ///  01-设备疑似被Root/设备疑似越狱。
        ///  02-设备疑似被注入。
        ///  03-设备疑似为模拟器。
        ///  04-设备疑似存在风险操作。
        ///  05-摄像头疑似被劫持。
        ///  06-疑似黑产设备。
        ///  空表示没有相机指纹风险。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CameraInfoTag")]
        public string CameraInfoTag{ get; set; }

        /// <summary>
        /// 获取token时透传的信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Extra")]
        public string Extra{ get; set; }

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
            this.SetParamSimple(map, prefix + "DeviceInfoTag", this.DeviceInfoTag);
            this.SetParamSimple(map, prefix + "DeviceInfoLevel", this.DeviceInfoLevel);
            this.SetParamSimple(map, prefix + "OpenId", this.OpenId);
            this.SetParamSimple(map, prefix + "CameraInfoLevel", this.CameraInfoLevel);
            this.SetParamSimple(map, prefix + "CameraInfoTag", this.CameraInfoTag);
            this.SetParamSimple(map, prefix + "Extra", this.Extra);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

