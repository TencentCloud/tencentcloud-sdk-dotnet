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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDashboardSubscribeRequest : AbstractModel
    {
        
        /// <summary>
        /// 仪表盘订阅id。通过 [获取仪表盘订阅列表](https://cloud.tencent.com/document/api/614/105779)接口获取Id。
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 仪表盘id。通过 [获取仪表盘](https://cloud.tencent.com/document/api/614/95636)接口获取DashboardId。
        /// </summary>
        [JsonProperty("DashboardId")]
        public string DashboardId{ get; set; }

        /// <summary>
        /// 仪表盘订阅名称。最大支持128个字符，且不支持'|'字符。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 订阅时间cron表达式，格式为：{秒数} {分钟} {小时} {日期} {月份} {星期}；（有效数据为：{分钟} {小时} {日期} {月份} {星期}）。
        /// </summary>
        [JsonProperty("Cron")]
        public string Cron{ get; set; }

        /// <summary>
        /// 仪表盘订阅数据。
        /// </summary>
        [JsonProperty("SubscribeData")]
        public DashboardSubscribeData SubscribeData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "DashboardId", this.DashboardId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Cron", this.Cron);
            this.SetParamObj(map, prefix + "SubscribeData.", this.SubscribeData);
        }
    }
}

