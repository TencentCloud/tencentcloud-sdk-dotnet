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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExportAssetProcessInfoListRequest : AbstractModel
    {
        
        /// <summary>
        /// 查询指定Quuid主机的信息
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// 过滤条件。
        /// <li>Name - String - 是否必填：否 - 进程名</li>
        /// <li>User - String - 是否必填：否 - 进程用户</li>
        /// <li>Group - String - 是否必填：否 - 进程用户组</li>
        /// <li>Pid - uint64 - 是否必填：否 - 进程ID</li>
        /// <li>Ppid - uint64 - 是否必填：否 - 父进程ID</li>
        /// <li>OsType - uint64 - 是否必填：否 - windows/linux</li>
        /// <li>Status - string - 是否必填：否 - 进程状态：
        /// 0:全部
        /// 1:R 可执行
        /// 2:S 可中断
        /// 3:不可中断</li>
        /// <li>RunTimeStart - String - 是否必填：否 - 运行开始时间</li>
        /// <li>RunTimeEnd - String - 是否必填：否 - 运行结束时间</li>
        /// <li>InstallByPackage - uint64 - 是否必填：否 - 是否包安装：0否，1是</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 排序方式，asc升序 或 desc降序
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// 排序方式：[FirstTime|StartTime]
        /// </summary>
        [JsonProperty("By")]
        public string By{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "By", this.By);
        }
    }
}

