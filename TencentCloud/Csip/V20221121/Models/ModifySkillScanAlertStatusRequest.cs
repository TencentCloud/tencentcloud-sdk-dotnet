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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifySkillScanAlertStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// 告警记录 ID 列表
        /// 入参限制：单次最多 100 个
        /// 取值参考：通过 DescribeSkillScanAlertList 接口获取
        /// </summary>
        [JsonProperty("IDs")]
        public long?[] IDs{ get; set; }

        /// <summary>
        /// 目标处理状态
        /// 枚举值：
        /// 1：已处理
        /// 2：已忽略
        /// 3：已信任
        /// 4：已删除（软删除）
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 集团账号的成员 id
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "IDs.", this.IDs);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
        }
    }
}

