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

namespace TencentCloud.Weilingwith.V20230427.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ActionObj : AbstractModel
    {
        
        /// <summary>
        /// 动作id
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 动作名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 动作类型。（app/推送消息至应用-携带空间设备：无,appWithNearbyDevices/推送至应用-携带空间设备：携带,device/推送消息至设备-指定设备,nearbyDevices/推送消息至设备-事件所在范围内的设备,toAlarm/转换为告警,toNotification/转换为通知）
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 动作说明
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// 消息类型，orgin/custom/model
        /// </summary>
        [JsonProperty("MsgType")]
        public string MsgType{ get; set; }

        /// <summary>
        /// 消息内容
        /// </summary>
        [JsonProperty("MsgContent")]
        public string MsgContent{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 动作下沉配置
        /// </summary>
        [JsonProperty("SinkConfig")]
        public string SinkConfig{ get; set; }

        /// <summary>
        ///  具体应用（appid）/具体设备（DIN/subID）
        /// </summary>
        [JsonProperty("ApplyDevice")]
        public string ApplyDevice{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamSimple(map, prefix + "MsgType", this.MsgType);
            this.SetParamSimple(map, prefix + "MsgContent", this.MsgContent);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "SinkConfig", this.SinkConfig);
            this.SetParamSimple(map, prefix + "ApplyDevice", this.ApplyDevice);
        }
    }
}

