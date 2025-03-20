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

    public class GroupDeviceItem : AbstractModel
    {
        
        /// <summary>
        /// 设备唯一标识
        /// </summary>
        [JsonProperty("DeviceId")]
        public string DeviceId{ get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// 设备状态
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonProperty("ExtraInformation")]
        public string ExtraInformation{ get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        [JsonProperty("DeviceType")]
        public long? DeviceType{ get; set; }

        /// <summary>
        /// rtsp地址
        /// </summary>
        [JsonProperty("RTSPUrl")]
        public string RTSPUrl{ get; set; }

        /// <summary>
        /// 设备编码
        /// </summary>
        [JsonProperty("DeviceCode")]
        public string DeviceCode{ get; set; }

        /// <summary>
        /// 是否存在录像
        /// </summary>
        [JsonProperty("IsRecord")]
        public long? IsRecord{ get; set; }

        /// <summary>
        /// 该设备是否可录制
        /// </summary>
        [JsonProperty("Recordable")]
        public long? Recordable{ get; set; }

        /// <summary>
        /// 设备接入协议
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 设备创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// 设备通道总数
        /// </summary>
        [JsonProperty("ChannelNum")]
        public long? ChannelNum{ get; set; }

        /// <summary>
        /// 设备视频通道总数
        /// </summary>
        [JsonProperty("VideoChannelNum")]
        public long? VideoChannelNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ExtraInformation", this.ExtraInformation);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamSimple(map, prefix + "RTSPUrl", this.RTSPUrl);
            this.SetParamSimple(map, prefix + "DeviceCode", this.DeviceCode);
            this.SetParamSimple(map, prefix + "IsRecord", this.IsRecord);
            this.SetParamSimple(map, prefix + "Recordable", this.Recordable);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ChannelNum", this.ChannelNum);
            this.SetParamSimple(map, prefix + "VideoChannelNum", this.VideoChannelNum);
        }
    }
}

