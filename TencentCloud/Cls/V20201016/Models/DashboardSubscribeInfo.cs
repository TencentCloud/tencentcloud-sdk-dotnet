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

    public class DashboardSubscribeInfo : AbstractModel
    {
        
        /// <summary>
        /// 仪表盘订阅id。
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 仪表盘订阅名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 仪表盘id。
        /// </summary>
        [JsonProperty("DashboardId")]
        public string DashboardId{ get; set; }

        /// <summary>
        /// 仪表盘订阅时间。
        /// </summary>
        [JsonProperty("Cron")]
        public string Cron{ get; set; }

        /// <summary>
        /// 仪表盘订阅数据。
        /// </summary>
        [JsonProperty("SubscribeData")]
        public DashboardSubscribeData SubscribeData{ get; set; }

        /// <summary>
        /// 仪表盘订阅记录创建时间。格式：`YYYY-MM-DD HH:MM:SS`
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 仪表盘订阅记录更新时间。格式：`YYYY-MM-DD HH:MM:SS`
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 仪表盘订阅记录最后一次发送成功时间。格式：`YYYY-MM-DD HH:MM:SS`
        /// </summary>
        [JsonProperty("LastTime")]
        public string LastTime{ get; set; }

        /// <summary>
        /// 腾讯云主账号Id。
        /// </summary>
        [JsonProperty("Uin")]
        public ulong? Uin{ get; set; }

        /// <summary>
        /// 腾讯云主账号下的子账号Id。
        /// </summary>
        [JsonProperty("SubUin")]
        public ulong? SubUin{ get; set; }

        /// <summary>
        /// 仪表盘订阅记录最后一次发送的状态。success：全部发送成功，fail：未发送， partialSuccess：部分发送成功。
        /// </summary>
        [JsonProperty("LastStatus")]
        public string LastStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "DashboardId", this.DashboardId);
            this.SetParamSimple(map, prefix + "Cron", this.Cron);
            this.SetParamObj(map, prefix + "SubscribeData.", this.SubscribeData);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "LastTime", this.LastTime);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "SubUin", this.SubUin);
            this.SetParamSimple(map, prefix + "LastStatus", this.LastStatus);
        }
    }
}

