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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTasksRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID，格式如：cdb-c1nl9rpv，与云数据库控制台页面中显示的实例 ID 相同，可使用 [查询实例列表](https://cloud.tencent.com/document/api/236/15872) 接口获取，其值为输出参数中字段 InstanceId 的值。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 异步任务请求 ID，执行云数据库相关操作返回的 AsyncRequestId。
        /// </summary>
        [JsonProperty("AsyncRequestId")]
        public string AsyncRequestId{ get; set; }

        /// <summary>
        /// 任务类型，不传值则查询所有任务类型，支持的值包括：
        /// 1 - 数据库回档；
        /// 2 - SQL操作；
        /// 3 - 数据导入；
        /// 5 - 参数设置；
        /// 6 - 初始化云数据库实例；
        /// 7 - 重启云数据库实例；
        /// 8 - 开启云数据库实例GTID；
        /// 9 - 只读实例升级；
        /// 10 - 数据库批量回档；
        /// 11 - 主实例升级；
        /// 12 - 删除云数据库库表；
        /// 13 - 灾备实例提升为主。
        /// </summary>
        [JsonProperty("TaskTypes")]
        public long?[] TaskTypes{ get; set; }

        /// <summary>
        /// 任务状态，不传值则查询所有任务状态，支持的值包括：
        /// -1 - 未定义；
        /// 0 - 初始化；
        /// 1 - 运行中；
        /// 2 - 执行成功；
        /// 3 - 执行失败；
        /// 4 - 已终止；
        /// 5 - 已删除；
        /// 6 - 已暂停。
        /// </summary>
        [JsonProperty("TaskStatus")]
        public long?[] TaskStatus{ get; set; }

        /// <summary>
        /// 第一个任务的开始时间，用于范围查询，时间格式如：2017-12-31 10:40:01。
        /// </summary>
        [JsonProperty("StartTimeBegin")]
        public string StartTimeBegin{ get; set; }

        /// <summary>
        /// 最后一个任务的开始时间，用于范围查询，时间格式如：2017-12-31 10:40:01。
        /// </summary>
        [JsonProperty("StartTimeEnd")]
        public string StartTimeEnd{ get; set; }

        /// <summary>
        /// 记录偏移量，默认值为0。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 单次请求返回的数量，默认值为20，最大值为100。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "AsyncRequestId", this.AsyncRequestId);
            this.SetParamArraySimple(map, prefix + "TaskTypes.", this.TaskTypes);
            this.SetParamArraySimple(map, prefix + "TaskStatus.", this.TaskStatus);
            this.SetParamSimple(map, prefix + "StartTimeBegin", this.StartTimeBegin);
            this.SetParamSimple(map, prefix + "StartTimeEnd", this.StartTimeEnd);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

