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

    public class TaskContent : AbstractModel
    {
        
        /// <summary>
        /// 摄像头ID
        /// </summary>
        [JsonProperty("CameraId")]
        public ulong? CameraId{ get; set; }

        /// <summary>
        /// rtsp 地址
        /// </summary>
        [JsonProperty("RTSP")]
        public string RTSP{ get; set; }

        /// <summary>
        /// 图片上传地址
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CameraId", this.CameraId);
            this.SetParamSimple(map, prefix + "RTSP", this.RTSP);
            this.SetParamSimple(map, prefix + "Url", this.Url);
        }
    }
}

