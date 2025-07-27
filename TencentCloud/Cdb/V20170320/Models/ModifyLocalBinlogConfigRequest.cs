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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyLocalBinlogConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID，格式如：cdb-c1nl9rpv。与云数据库控制台页面中显示的实例 ID 相同。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 本地 binlog 保留时长。不同实例的可取值如下：
        /// 1. 云盘版实例、双节点实例、三节点实例的本地 binlog 保留时长（小时）默认为120，范围：6 - 168。
        /// 2. 灾备实例的本地 binlog 保留时长（小时）默认为120，范围：120 - 168。
        /// 3. 单节点云盘实例的本地 binlog 保留时长（小时）默认为120，范围：0 - 168。
        /// 4. 若双节点实例、三节点实例下无灾备实例，则该主实例的本地 binlog 保留时长（小时）范围是：6 - 168；若双节点实例、三节点实例下有灾备实例，或者要为双节点实例、三节点实例添加灾备实例，为避免同步异常，该主实例的本地 binlog 保留时长（小时）不能设置低于120小时，范围是：120 - 168。
        /// </summary>
        [JsonProperty("SaveHours")]
        public long? SaveHours{ get; set; }

        /// <summary>
        /// 本地 binlog 空间使用率，可取值范围：[30,50]。
        /// </summary>
        [JsonProperty("MaxUsage")]
        public long? MaxUsage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "SaveHours", this.SaveHours);
            this.SetParamSimple(map, prefix + "MaxUsage", this.MaxUsage);
        }
    }
}

