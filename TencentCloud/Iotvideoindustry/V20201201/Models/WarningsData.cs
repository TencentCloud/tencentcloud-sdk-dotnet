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

namespace TencentCloud.Iotvideoindustry.V20201201.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WarningsData : AbstractModel
    {
        
        /// <summary>
        /// 唯一ID
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 设备ID
        /// </summary>
        [JsonProperty("DeviceId")]
        public string DeviceId{ get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// 告警通道
        /// </summary>
        [JsonProperty("WarnChannel")]
        public string WarnChannel{ get; set; }

        /// <summary>
        /// 告警级别 1: "一级警情", 2: "二级警情", 3: "三级警情", 4: "四级警情",
        /// </summary>
        [JsonProperty("WarnLevel")]
        public long? WarnLevel{ get; set; }

        /// <summary>
        /// 告警级别名称
        /// </summary>
        [JsonProperty("WarnLevelName")]
        public string WarnLevelName{ get; set; }

        /// <summary>
        /// 告警方式 2 设备报警 5 视频报警 6 设备故障报警
        /// </summary>
        [JsonProperty("WarnMode")]
        public long? WarnMode{ get; set; }

        /// <summary>
        /// 告警方式名称
        /// </summary>
        [JsonProperty("WarnModeName")]
        public string WarnModeName{ get; set; }

        /// <summary>
        /// 告警类型  2: {
        /// 			Name: "设备报警",
        /// 			WarnType: map[int]string{
        /// 				1: "视频丢失报警",
        /// 				2: "设备防拆报警",
        /// 				3: "存储设备磁盘满报警",
        /// 				4: "设备高温报警",
        /// 				5: "设备低温报警",
        /// 			},
        /// 		},
        /// 		5: {
        /// 			Name: "视频报警",
        /// 			WarnType: map[int]string{
        /// 				1:  "人工视频报警",
        /// 				2:  "运动目标检测报警",
        /// 				3:  "遗留物检测报警",
        /// 				4:  "物体移除检测报警",
        /// 				5:  "绊线检测报警",
        /// 				6:  "入侵检测报警",
        /// 				7:  "逆行检测报警",
        /// 				8:  "徘徊检测报警",
        /// 				9:  "流量统计报警",
        /// 				10: "密度检测报警",
        /// 				11: "视频异常检测报警",
        /// 				12: "快速移动报警",
        /// 			},
        /// 		},
        /// 		6: {
        /// 			Name: "设备故障报警",
        /// 			WarnType: map[int]string{
        /// 				1: "存储设备磁盘故障报警",
        /// 				2: "存储设备风扇故障报警",
        /// 			},
        /// 		}
        /// </summary>
        [JsonProperty("WarnType")]
        public long? WarnType{ get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        [JsonProperty("Del")]
        public long? Del{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "WarnChannel", this.WarnChannel);
            this.SetParamSimple(map, prefix + "WarnLevel", this.WarnLevel);
            this.SetParamSimple(map, prefix + "WarnLevelName", this.WarnLevelName);
            this.SetParamSimple(map, prefix + "WarnMode", this.WarnMode);
            this.SetParamSimple(map, prefix + "WarnModeName", this.WarnModeName);
            this.SetParamSimple(map, prefix + "WarnType", this.WarnType);
            this.SetParamSimple(map, prefix + "Del", this.Del);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

