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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReleaseRecord : AbstractModel
    {
        
        /// <summary>
        /// 是否可导出
        /// </summary>
        [JsonProperty("CanExport")]
        public bool? CanExport{ get; set; }

        /// <summary>
        /// 是否可回滚
        /// </summary>
        [JsonProperty("CanRollback")]
        public bool? CanRollback{ get; set; }

        /// <summary>
        /// 发布描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 发布失败数
        /// </summary>
        [JsonProperty("FailCount")]
        public ulong? FailCount{ get; set; }

        /// <summary>
        /// 失败原因
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }

        /// <summary>
        /// 发布ID
        /// </summary>
        [JsonProperty("ReleaseId")]
        public string ReleaseId{ get; set; }

        /// <summary>
        /// 发布版本
        /// </summary>
        [JsonProperty("ReleaseVersion")]
        public string ReleaseVersion{ get; set; }

        /// <summary>
        /// 发布状态。枚举值: 1:待发布, 2:发布中, 3:发布成功, 4:发布失败, 5:审核中, 6:审核成功, 7:审核失败, 8:发布成功回调处理中, 9:发布暂停, 10:申诉审核中, 11:申诉审核通过, 12:申诉审核不通过
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 状态描述
        /// </summary>
        [JsonProperty("StatusDescription")]
        public string StatusDescription{ get; set; }

        /// <summary>
        /// 发布成功数
        /// </summary>
        [JsonProperty("SuccessCount")]
        public ulong? SuccessCount{ get; set; }

        /// <summary>
        /// 更新时间 (Unix时间戳,秒级)
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 发布人
        /// </summary>
        [JsonProperty("Updater")]
        public string Updater{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CanExport", this.CanExport);
            this.SetParamSimple(map, prefix + "CanRollback", this.CanRollback);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "FailCount", this.FailCount);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
            this.SetParamSimple(map, prefix + "ReleaseId", this.ReleaseId);
            this.SetParamSimple(map, prefix + "ReleaseVersion", this.ReleaseVersion);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StatusDescription", this.StatusDescription);
            this.SetParamSimple(map, prefix + "SuccessCount", this.SuccessCount);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Updater", this.Updater);
        }
    }
}

