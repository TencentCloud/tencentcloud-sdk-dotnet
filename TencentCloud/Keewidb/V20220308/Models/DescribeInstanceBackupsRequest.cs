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

namespace TencentCloud.Keewidb.V20220308.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstanceBackupsRequest : AbstractModel
    {
        
        /// <summary>
        /// 待操作的实例ID，可通过 DescribeInstance 接口返回值中的 InstanceId 获取。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 每页输出的备份列表大小，即每页输出的备份文件的数量，默认值20，取值范围为[1,100]。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 备份列表分页偏移量，取Limit整数倍。
        /// 计算公式为offset=limit*(页码-1)。例如 limit=10，第1页offset就为0，第2页offset就为10，依次类推。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 查询备份文件的开始时间，格式如：2017-02-08 16:46:34。查询实例在 [BeginTime, EndTime] 时间段内的备份列表。
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// 查询备份文件的结束时间，格式如：2017-02-08 19:09:26。查询实例在 [beginTime, endTime] 时间段内的备份列表。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 备份任务状态。<ul><li>1：备份在流程中。</li><li>2：备份正常。</li><li>3：备份转RDB文件处理中。</li><li>4：已完成RDB转换。</li><li>-1：备份已过期。</li><li>-2：备份已删除。</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public long?[] Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "Status.", this.Status);
        }
    }
}

