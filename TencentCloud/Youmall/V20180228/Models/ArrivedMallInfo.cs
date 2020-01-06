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

namespace TencentCloud.Youmall.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ArrivedMallInfo : AbstractModel
    {
        
        /// <summary>
        /// 到场时间
        /// </summary>
        [JsonProperty("ArrivedTime")]
        public string ArrivedTime{ get; set; }

        /// <summary>
        /// 出场时间
        /// </summary>
        [JsonProperty("LeaveTime")]
        public string LeaveTime{ get; set; }

        /// <summary>
        /// 停留时间，秒
        /// </summary>
        [JsonProperty("StaySecond")]
        public ulong? StaySecond{ get; set; }

        /// <summary>
        /// 到场抓拍图片
        /// </summary>
        [JsonProperty("InCapPic")]
        public string InCapPic{ get; set; }

        /// <summary>
        /// 出场抓拍图片
        /// </summary>
        [JsonProperty("OutCapPic")]
        public string OutCapPic{ get; set; }

        /// <summary>
        /// 轨迹编码
        /// </summary>
        [JsonProperty("TraceId")]
        public string TraceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ArrivedTime", this.ArrivedTime);
            this.SetParamSimple(map, prefix + "LeaveTime", this.LeaveTime);
            this.SetParamSimple(map, prefix + "StaySecond", this.StaySecond);
            this.SetParamSimple(map, prefix + "InCapPic", this.InCapPic);
            this.SetParamSimple(map, prefix + "OutCapPic", this.OutCapPic);
            this.SetParamSimple(map, prefix + "TraceId", this.TraceId);
        }
    }
}

