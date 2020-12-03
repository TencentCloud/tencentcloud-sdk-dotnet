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

    public class CreateCameraAlertAlert : AbstractModel
    {
        
        /// <summary>
        /// 集团编码
        /// </summary>
        [JsonProperty("GroupCode")]
        public string GroupCode{ get; set; }

        /// <summary>
        /// 广场ID
        /// </summary>
        [JsonProperty("MallId")]
        public ulong? MallId{ get; set; }

        /// <summary>
        /// 相机ID
        /// </summary>
        [JsonProperty("CameraId")]
        public ulong? CameraId{ get; set; }

        /// <summary>
        /// 时间戳,ms,默认为告警请求到达时间
        /// </summary>
        [JsonProperty("CaptureTime")]
        public long? CaptureTime{ get; set; }

        /// <summary>
        /// 图片base64编码
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// 移动告警
        /// </summary>
        [JsonProperty("MoveAlert")]
        public CreateCameraAlertsMoveAlert MoveAlert{ get; set; }

        /// <summary>
        /// 遮挡告警
        /// </summary>
        [JsonProperty("CoverAlert")]
        public CreateCameraAlertsCoverAlert CoverAlert{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupCode", this.GroupCode);
            this.SetParamSimple(map, prefix + "MallId", this.MallId);
            this.SetParamSimple(map, prefix + "CameraId", this.CameraId);
            this.SetParamSimple(map, prefix + "CaptureTime", this.CaptureTime);
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamObj(map, prefix + "MoveAlert.", this.MoveAlert);
            this.SetParamObj(map, prefix + "CoverAlert.", this.CoverAlert);
        }
    }
}

