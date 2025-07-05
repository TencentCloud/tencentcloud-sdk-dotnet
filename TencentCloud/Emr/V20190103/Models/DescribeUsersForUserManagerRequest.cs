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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeUsersForUserManagerRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("PageNo")]
        public long? PageNo{ get; set; }

        /// <summary>
        /// 分页的大小。
        /// 默认查询全部；PageNo和PageSize不合理的设置，都是查询全部
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 查询用户列表过滤器
        /// </summary>
        [JsonProperty("UserManagerFilter")]
        public UserManagerFilter UserManagerFilter{ get; set; }

        /// <summary>
        /// 是否需要keytab文件的信息，仅对开启kerberos的集群有效，默认为false
        /// </summary>
        [JsonProperty("NeedKeytabInfo")]
        public bool? NeedKeytabInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "PageNo", this.PageNo);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamObj(map, prefix + "UserManagerFilter.", this.UserManagerFilter);
            this.SetParamSimple(map, prefix + "NeedKeytabInfo", this.NeedKeytabInfo);
        }
    }
}

