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

namespace TencentCloud.Ioa.V20220601.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDeviceChildGroupsRequest : AbstractModel
    {
        
        /// <summary>
        /// 管理域实例ID，用于CAM管理域权限分配。若企业未进行管理域的划分，可直接传入根域"1"，此时表示针对当前企业的全部设备和账号进行接口CRUD，具体CRUD的影响范围限制于相应接口的入参。
        /// </summary>
        [JsonProperty("DomainInstanceId")]
        public string DomainInstanceId{ get; set; }

        /// <summary>
        /// 过滤条件参数（字段含义请参考接口返回值）
        /// - Name, 类型String，支持操作：【like，ilike】，支持排序
        /// 
        /// 
        /// 
        /// 
        /// 分页参数
        /// - PageNum 从1开始，小于等于0时使用默认参数
        /// - PageSize 最大值5000，最好不超过100
        /// </summary>
        [JsonProperty("Condition")]
        public Condition Condition{ get; set; }

        /// <summary>
        /// 父分组id，默认0：表示获取全网终端分组
        /// </summary>
        [JsonProperty("ParentId")]
        public long? ParentId{ get; set; }

        /// <summary>
        /// 操作系统类型（0：win，1：linux，2：mac，4：android，5：ios；默认0：系统win）
        /// </summary>
        [JsonProperty("OsType")]
        public long? OsType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DomainInstanceId", this.DomainInstanceId);
            this.SetParamObj(map, prefix + "Condition.", this.Condition);
            this.SetParamSimple(map, prefix + "ParentId", this.ParentId);
            this.SetParamSimple(map, prefix + "OsType", this.OsType);
        }
    }
}

