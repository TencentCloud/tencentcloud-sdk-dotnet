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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAccidentEventListRequest : AbstractModel
    {
        
        /// <summary>
        /// 接口模块名，当前接口取值monitor
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// 起始时间，默认一天前的时间戳
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// 结束时间，默认当前时间戳
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// 每页返回的数量，默认20
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 页偏移量，默认0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 根据UpdateTime排序的规则，取值asc或desc
        /// </summary>
        [JsonProperty("UpdateTimeOrder")]
        public string UpdateTimeOrder{ get; set; }

        /// <summary>
        /// 根据OccurTime排序的规则，取值asc或desc（优先根据UpdateTimeOrder排序）
        /// </summary>
        [JsonProperty("OccurTimeOrder")]
        public string OccurTimeOrder{ get; set; }

        /// <summary>
        /// 根据事件类型过滤，1表示服务问题，2表示其他订阅
        /// </summary>
        [JsonProperty("AccidentType")]
        public long?[] AccidentType{ get; set; }

        /// <summary>
        /// 根据事件过滤，1表示云服务器存储问题，2表示云服务器网络连接问题，3表示云服务器运行异常，202表示运营商网络抖动
        /// </summary>
        [JsonProperty("AccidentEvent")]
        public long?[] AccidentEvent{ get; set; }

        /// <summary>
        /// 根据事件状态过滤，0表示已恢复，1表示未恢复
        /// </summary>
        [JsonProperty("AccidentStatus")]
        public long?[] AccidentStatus{ get; set; }

        /// <summary>
        /// 根据事件地域过滤，gz表示广州，sh表示上海等
        /// </summary>
        [JsonProperty("AccidentRegion")]
        public string[] AccidentRegion{ get; set; }

        /// <summary>
        /// 根据影响资源过滤，比如ins-19a06bka
        /// </summary>
        [JsonProperty("AffectResource")]
        public string AffectResource{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "UpdateTimeOrder", this.UpdateTimeOrder);
            this.SetParamSimple(map, prefix + "OccurTimeOrder", this.OccurTimeOrder);
            this.SetParamArraySimple(map, prefix + "AccidentType.", this.AccidentType);
            this.SetParamArraySimple(map, prefix + "AccidentEvent.", this.AccidentEvent);
            this.SetParamArraySimple(map, prefix + "AccidentStatus.", this.AccidentStatus);
            this.SetParamArraySimple(map, prefix + "AccidentRegion.", this.AccidentRegion);
            this.SetParamSimple(map, prefix + "AffectResource", this.AffectResource);
        }
    }
}

