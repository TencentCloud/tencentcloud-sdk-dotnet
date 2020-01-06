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

    public class CopyAccountPrivilegesRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID，形如：tdsql-ow728lmc，可以通过 DescribeDBInstances 查询实例详情获得。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 源用户名
        /// </summary>
        [JsonProperty("SrcUserName")]
        public string SrcUserName{ get; set; }

        /// <summary>
        /// 源用户允许的访问 host
        /// </summary>
        [JsonProperty("SrcHost")]
        public string SrcHost{ get; set; }

        /// <summary>
        /// 目的用户名
        /// </summary>
        [JsonProperty("DstUserName")]
        public string DstUserName{ get; set; }

        /// <summary>
        /// 目的用户允许的访问 host
        /// </summary>
        [JsonProperty("DstHost")]
        public string DstHost{ get; set; }

        /// <summary>
        /// 源账号的 ReadOnly 属性
        /// </summary>
        [JsonProperty("SrcReadOnly")]
        public string SrcReadOnly{ get; set; }

        /// <summary>
        /// 目的账号的 ReadOnly 属性
        /// </summary>
        [JsonProperty("DstReadOnly")]
        public string DstReadOnly{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "SrcUserName", this.SrcUserName);
            this.SetParamSimple(map, prefix + "SrcHost", this.SrcHost);
            this.SetParamSimple(map, prefix + "DstUserName", this.DstUserName);
            this.SetParamSimple(map, prefix + "DstHost", this.DstHost);
            this.SetParamSimple(map, prefix + "SrcReadOnly", this.SrcReadOnly);
            this.SetParamSimple(map, prefix + "DstReadOnly", this.DstReadOnly);
        }
    }
}

