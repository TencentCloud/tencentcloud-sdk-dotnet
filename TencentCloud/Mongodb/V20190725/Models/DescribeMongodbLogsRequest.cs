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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMongodbLogsRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID。请登录 [MongoDB 控制台](https://console.cloud.tencent.com/mongodb#/)在实例列表复制实例 ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 查询日志的开启时间。
        /// - 格式：yyyy-mm-dd hh:mm:ss，如：2019-06-01 10:00:00。
        /// - 查询时间范围：仅支持查询最近 7 天内的日志数据。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 查询日志的结束时间。
        /// - 格式：yyyy-mm-dd hh:mm:ss，如：2019-06-01 10:00:00。
        /// - 查询时间范围：仅支持查询最近 7 天内的日志数据。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 节点 ID。请登录 [MongoDB 控制台](https://console.cloud.tencent.com/mongodb)的**节点管理**页面获取查询的节点 ID。
        /// </summary>
        [JsonProperty("NodeNames")]
        public string[] NodeNames{ get; set; }

        /// <summary>
        /// 日志类别。
        /// - 日志类别包括但不限于 COMMAND、ACCESS、CONTROL、FTDC、INDEX、NETWORK、QUERY、REPL、SHARDING、STORAGE、RECOVERY、JOURNAL 和 WRITE 等。具体支持的类别可能会因 MongoDB 的版本而存在差异。具体信息，请参见[日志消息](https://www.mongodb.com/zh-cn/docs/v5.0/reference/log-messages/#log-message-examples)。
        /// - 登录 [MongoDB 控制台](https://console.cloud.tencent.com/mongodb)，在**日志管理**页面的**错误日志**页签，也可查看**日志类别**。
        /// </summary>
        [JsonProperty("LogComponents")]
        public string[] LogComponents{ get; set; }

        /// <summary>
        /// 日志级别。
        /// - 日志级别按严重性从高到低依次为：FATAL、ERROR、WARNING。
        /// - 登录 [MongoDB 控制台](https://console.cloud.tencent.com/mongodb)，在**日志管理**页面的**错误日志**页签，可查看**日志级别**。
        /// </summary>
        [JsonProperty("LogLevels")]
        public string[] LogLevels{ get; set; }

        /// <summary>
        /// 日志 ID。登录 [MongoDB 控制台](https://console.cloud.tencent.com/mongodb)，在**日志管理**页面的**错误日志**页签，可查看**日志 ID**。
        /// </summary>
        [JsonProperty("LogIds")]
        public string[] LogIds{ get; set; }

        /// <summary>
        /// 日志连接信息。登录 [MongoDB 控制台](https://console.cloud.tencent.com/mongodb)，在**日志管理**页面的**错误日志**页签，可查看**日志连接信息**。
        /// </summary>
        [JsonProperty("LogConnections")]
        public string[] LogConnections{ get; set; }

        /// <summary>
        /// 指定日志筛选的字段。
        /// </summary>
        [JsonProperty("LogDetailParams")]
        public string[] LogDetailParams{ get; set; }

        /// <summary>
        /// 偏移量，最小值为0，最大值为10000，默认值为0。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 分页大小，最小值为1，最大值为100，默认值为20。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "NodeNames.", this.NodeNames);
            this.SetParamArraySimple(map, prefix + "LogComponents.", this.LogComponents);
            this.SetParamArraySimple(map, prefix + "LogLevels.", this.LogLevels);
            this.SetParamArraySimple(map, prefix + "LogIds.", this.LogIds);
            this.SetParamArraySimple(map, prefix + "LogConnections.", this.LogConnections);
            this.SetParamArraySimple(map, prefix + "LogDetailParams.", this.LogDetailParams);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

