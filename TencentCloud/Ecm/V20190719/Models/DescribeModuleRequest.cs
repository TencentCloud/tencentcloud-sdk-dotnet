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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeModuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 过滤条件。
        /// module-name - string - 是否必填：否 - （过滤条件）按照模块名称过滤。
        /// module-id - string - 是否必填：否 - （过滤条件）按照模块ID过滤。
        /// image-id      String      是否必填：否      （过滤条件）按照镜像ID过滤。
        /// instance-family      String      是否必填：否      （过滤条件）按照机型family过滤。
        /// security-group-id - string 是否必填：否 - （过滤条件）按照模块绑定的安全组id过滤。
        /// 每次请求的Filters的上限为10，Filter.Values的上限为5。
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。关于Offset的更进一步介绍请参考 API 简介中的相关小节。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 返回数量，默认为20，最大值为100。关于Limit的更进一步介绍请参考 API 简介中的相关小节。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 指定排序字段。目前支持的可选值如下
        /// instance-num 按实例数量排序。
        /// node-num 按节点数量排序。
        /// timestamp 按实例创建时间排序。
        /// 如果不传，默认按实例创建时间排序
        /// </summary>
        [JsonProperty("OrderByField")]
        public string OrderByField{ get; set; }

        /// <summary>
        /// 指定排序是降序还是升序。0表示降序； 1表示升序。如果不传默认为降序
        /// </summary>
        [JsonProperty("OrderDirection")]
        public long? OrderDirection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "OrderByField", this.OrderByField);
            this.SetParamSimple(map, prefix + "OrderDirection", this.OrderDirection);
        }
    }
}

