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

    public class CameraConfig : AbstractModel
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
        /// 楼层ID
        /// </summary>
        [JsonProperty("FloorId")]
        public long? FloorId{ get; set; }

        /// <summary>
        /// 摄像头ID
        /// </summary>
        [JsonProperty("CameraId")]
        public ulong? CameraId{ get; set; }

        /// <summary>
        /// 摄像头IP
        /// </summary>
        [JsonProperty("CameraIp")]
        public string CameraIp{ get; set; }

        /// <summary>
        /// 摄像头Mac
        /// </summary>
        [JsonProperty("CameraMac")]
        public string CameraMac{ get; set; }

        /// <summary>
        /// 摄像头类型:
        /// 1: 码流机
        /// 2: AI相机
        /// </summary>
        [JsonProperty("CameraType")]
        public long? CameraType{ get; set; }

        /// <summary>
        /// 摄像头功能:
        /// 1: 人脸
        /// 2: 人体
        /// </summary>
        [JsonProperty("CameraFeature")]
        public long? CameraFeature{ get; set; }

        /// <summary>
        /// 摄像头是否启用:
        /// 0: 下线
        /// 1: 启用
        /// </summary>
        [JsonProperty("CameraState")]
        public long? CameraState{ get; set; }

        /// <summary>
        /// 点位ID
        /// </summary>
        [JsonProperty("ZoneId")]
        public ulong? ZoneId{ get; set; }

        /// <summary>
        /// 点位类型:
        /// 1: 场门
        /// 3: 层门
        /// 5: 特殊区域
        /// 7: 门店
        /// 8: 补位
        /// 10: 开放式门店
        /// 11: 品类区
        /// 12: 公共区
        /// </summary>
        [JsonProperty("ZoneType")]
        public long? ZoneType{ get; set; }

        /// <summary>
        /// 配置
        /// </summary>
        [JsonProperty("Config")]
        public Config Config{ get; set; }

        /// <summary>
        /// 宽
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// 高
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupCode", this.GroupCode);
            this.SetParamSimple(map, prefix + "MallId", this.MallId);
            this.SetParamSimple(map, prefix + "FloorId", this.FloorId);
            this.SetParamSimple(map, prefix + "CameraId", this.CameraId);
            this.SetParamSimple(map, prefix + "CameraIp", this.CameraIp);
            this.SetParamSimple(map, prefix + "CameraMac", this.CameraMac);
            this.SetParamSimple(map, prefix + "CameraType", this.CameraType);
            this.SetParamSimple(map, prefix + "CameraFeature", this.CameraFeature);
            this.SetParamSimple(map, prefix + "CameraState", this.CameraState);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ZoneType", this.ZoneType);
            this.SetParamObj(map, prefix + "Config.", this.Config);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
        }
    }
}

