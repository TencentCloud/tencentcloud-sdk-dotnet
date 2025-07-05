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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CasterBriefInfo : AbstractModel
    {
        
        /// <summary>
        /// 导播台ID
        /// </summary>
        [JsonProperty("CasterId")]
        public ulong? CasterId{ get; set; }

        /// <summary>
        /// 导播台名称
        /// </summary>
        [JsonProperty("CasterName")]
        public string CasterName{ get; set; }

        /// <summary>
        /// 导播台的描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 开始计费时间，值为unix时间戳
        /// </summary>
        [JsonProperty("StartBillingTime")]
        public ulong? StartBillingTime{ get; set; }

        /// <summary>
        /// 结束计费时间，值为unix时间戳
        /// </summary>
        [JsonProperty("StopBillingTime")]
        public ulong? StopBillingTime{ get; set; }

        /// <summary>
        /// 创建时间，值为unix时间戳
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// 导播台状态
        /// 0：停止状态，无预监，无主监
        /// 1：无预监，有主监
        /// 2：有预监，无主监
        /// 3：有预监，有主监
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 导播台的过期时间，值为-1或unix时间戳。
        /// 当值为-1时，代表永不过期。
        /// 当值为特定unix时间戳时，代表过期时间为对应的时间，导播台在该时间自动停止。
        /// </summary>
        [JsonProperty("ExpireTime")]
        public long? ExpireTime{ get; set; }

        /// <summary>
        /// 计费字段，该字段暂无作用
        /// </summary>
        [JsonProperty("FeeType")]
        public long? FeeType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CasterId", this.CasterId);
            this.SetParamSimple(map, prefix + "CasterName", this.CasterName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "StartBillingTime", this.StartBillingTime);
            this.SetParamSimple(map, prefix + "StopBillingTime", this.StopBillingTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "FeeType", this.FeeType);
        }
    }
}

