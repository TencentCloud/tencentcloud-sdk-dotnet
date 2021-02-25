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

namespace TencentCloud.Ump.V20200918.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CameraZones : AbstractModel
    {
        
        /// <summary>
        /// 摄像头ID
        /// </summary>
        [JsonProperty("CameraId")]
        public ulong? CameraId{ get; set; }

        /// <summary>
        /// 摄像头名称
        /// </summary>
        [JsonProperty("CameraName")]
        public string CameraName{ get; set; }

        /// <summary>
        /// 摄像头功能:
        /// 1: 人脸
        /// 2: 人体
        /// </summary>
        [JsonProperty("CameraFeature")]
        public long? CameraFeature{ get; set; }

        /// <summary>
        /// 摄像头IP
        /// </summary>
        [JsonProperty("CameraIp")]
        public string CameraIp{ get; set; }

        /// <summary>
        /// 摄像头状态:
        /// 0: 异常 (不再使用)
        /// 1: 正常 (不再使用)
        /// 10: 初始化
        /// 11: 未知状态 (因服务内部错误产生)
        /// 12: 网络异常
        /// 13: 未授权
        /// 14: 相机App异常
        /// 15: 相机取流异常
        /// 16: 正常
        /// </summary>
        [JsonProperty("CameraState")]
        public long? CameraState{ get; set; }

        /// <summary>
        /// 点位列表
        /// </summary>
        [JsonProperty("Zones")]
        public BunkZone[] Zones{ get; set; }

        /// <summary>
        /// 像素:
        /// 130W(1280*960)
        /// 200W(1920*1080)
        /// 400W(2560*1440)
        /// </summary>
        [JsonProperty("Pixel")]
        public string Pixel{ get; set; }

        /// <summary>
        /// 相机Rtsp地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RTSP")]
        public string RTSP{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CameraId", this.CameraId);
            this.SetParamSimple(map, prefix + "CameraName", this.CameraName);
            this.SetParamSimple(map, prefix + "CameraFeature", this.CameraFeature);
            this.SetParamSimple(map, prefix + "CameraIp", this.CameraIp);
            this.SetParamSimple(map, prefix + "CameraState", this.CameraState);
            this.SetParamArrayObj(map, prefix + "Zones.", this.Zones);
            this.SetParamSimple(map, prefix + "Pixel", this.Pixel);
            this.SetParamSimple(map, prefix + "RTSP", this.RTSP);
        }
    }
}

