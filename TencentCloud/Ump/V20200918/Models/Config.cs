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

    public class Config : AbstractModel
    {
        
        /// <summary>
        /// 摄像头厂商:
        /// H: 海康
        /// D: 大华
        /// Y: 英飞拓
        /// L: 联纵
        /// </summary>
        [JsonProperty("CameraProducer")]
        public string CameraProducer{ get; set; }

        /// <summary>
        /// rtsp 地址
        /// </summary>
        [JsonProperty("RTSP")]
        public string RTSP{ get; set; }

        /// <summary>
        /// 摄像头帧率
        /// </summary>
        [JsonProperty("Fps")]
        public long? Fps{ get; set; }

        /// <summary>
        /// 解码帧率
        /// </summary>
        [JsonProperty("DecodeFps")]
        public long? DecodeFps{ get; set; }

        /// <summary>
        /// 是否做客流计算:
        /// 0: 否
        /// 1: 是
        /// </summary>
        [JsonProperty("PassengerFlow")]
        public long? PassengerFlow{ get; set; }

        /// <summary>
        /// 是否打开人脸曝光:
        /// 0: 关闭
        /// 1: 开启
        /// </summary>
        [JsonProperty("FaceExpose")]
        public long? FaceExpose{ get; set; }

        /// <summary>
        /// 门线标注
        /// </summary>
        [JsonProperty("MallArea")]
        public Point[] MallArea{ get; set; }

        /// <summary>
        /// 店门标注
        /// </summary>
        [JsonProperty("ShopArea")]
        public Point[] ShopArea{ get; set; }

        /// <summary>
        /// 检测区标注
        /// </summary>
        [JsonProperty("TrackAreas")]
        public Polygon[] TrackAreas{ get; set; }

        /// <summary>
        /// 点位列表（品类区）
        /// </summary>
        [JsonProperty("Zones")]
        public ZoneArea[] Zones{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CameraProducer", this.CameraProducer);
            this.SetParamSimple(map, prefix + "RTSP", this.RTSP);
            this.SetParamSimple(map, prefix + "Fps", this.Fps);
            this.SetParamSimple(map, prefix + "DecodeFps", this.DecodeFps);
            this.SetParamSimple(map, prefix + "PassengerFlow", this.PassengerFlow);
            this.SetParamSimple(map, prefix + "FaceExpose", this.FaceExpose);
            this.SetParamArrayObj(map, prefix + "MallArea.", this.MallArea);
            this.SetParamArrayObj(map, prefix + "ShopArea.", this.ShopArea);
            this.SetParamArrayObj(map, prefix + "TrackAreas.", this.TrackAreas);
            this.SetParamArrayObj(map, prefix + "Zones.", this.Zones);
        }
    }
}

