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

    public class ZoneConfig : AbstractModel
    {
        
        /// <summary>
        /// 点位ID
        /// </summary>
        [JsonProperty("ZoneId")]
        public ulong? ZoneId{ get; set; }

        /// <summary>
        /// 点位名称
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

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
        /// 铺位编码
        /// </summary>
        [JsonProperty("BunkCodes")]
        public string BunkCodes{ get; set; }

        /// <summary>
        /// 楼层名称
        /// </summary>
        [JsonProperty("FloorName")]
        public string FloorName{ get; set; }

        /// <summary>
        /// 楼层ID
        /// </summary>
        [JsonProperty("FloorId")]
        public long? FloorId{ get; set; }

        /// <summary>
        /// 绑定数
        /// </summary>
        [JsonProperty("BindNum")]
        public long? BindNum{ get; set; }

        /// <summary>
        /// 调试数
        /// </summary>
        [JsonProperty("DebugNum")]
        public long? DebugNum{ get; set; }

        /// <summary>
        /// 下发状态:
        /// 1: 不可下发
        /// 2: 可下发
        /// 3: 已下发
        /// </summary>
        [JsonProperty("State")]
        public long? State{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "ZoneType", this.ZoneType);
            this.SetParamSimple(map, prefix + "BunkCodes", this.BunkCodes);
            this.SetParamSimple(map, prefix + "FloorName", this.FloorName);
            this.SetParamSimple(map, prefix + "FloorId", this.FloorId);
            this.SetParamSimple(map, prefix + "BindNum", this.BindNum);
            this.SetParamSimple(map, prefix + "DebugNum", this.DebugNum);
            this.SetParamSimple(map, prefix + "State", this.State);
        }
    }
}

