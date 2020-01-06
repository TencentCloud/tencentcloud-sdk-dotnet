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

namespace TencentCloud.Mariadb.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDBLogFilesResponse : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID，形如：tdsql-ow728lmc。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 请求日志类型，取值只能为1、2、3或者4。1-binlog，2-冷备，3-errlog，4-slowlog。
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// 请求日志总数
        /// </summary>
        [JsonProperty("Total")]
        public ulong? Total{ get; set; }

        /// <summary>
        /// 包含uri、length、mtime（修改时间）等信息
        /// </summary>
        [JsonProperty("Files")]
        public LogFileInfo[] Files{ get; set; }

        /// <summary>
        /// 如果是VPC网络的实例，做用本前缀加上URI为下载地址
        /// </summary>
        [JsonProperty("VpcPrefix")]
        public string VpcPrefix{ get; set; }

        /// <summary>
        /// 如果是普通网络的实例，做用本前缀加上URI为下载地址
        /// </summary>
        [JsonProperty("NormalPrefix")]
        public string NormalPrefix{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamArrayObj(map, prefix + "Files.", this.Files);
            this.SetParamSimple(map, prefix + "VpcPrefix", this.VpcPrefix);
            this.SetParamSimple(map, prefix + "NormalPrefix", this.NormalPrefix);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

