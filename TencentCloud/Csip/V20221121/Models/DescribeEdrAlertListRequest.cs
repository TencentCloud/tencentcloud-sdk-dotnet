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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeEdrAlertListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>集团账号的成员id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>过滤条件，支持的 Name 如下：<br/>【资源属性过滤】（前缀模糊，后端自动反查资产后按实例过滤）<br/>InstanceName - string - 是否必填：否 - 资产名称（前缀匹配）<br/>InstanceID - string - 是否必填：否 - 实例ID（前缀匹配）<br/>IP - string - 是否必填：否 - IP地址，支持内网/外网IP（前缀匹配）<br/>Tags - string - 是否必填：否 - 腾讯云标签，格式 tagKey$tagValue（仅单账号场景生效）<br/>CSIPTag - string - 是否必填：否 - 安全中心标签名称（前缀匹配，按语言环境匹配中/英文字段）<br/>AssetTagIds - string - 是否必填：否 - 安全中心资产标签ID（精确匹配，多个标签ID之间为或关系；标签ID可通过资产中心标签树接口 DescribeAssetTagTree 获取）<br/>【容器维度过滤】（前缀模糊，命中后仅返回容器告警）<br/>ClusterName - string - 是否必填：否 - 集群名称（前缀匹配）<br/>ContainerName - string - 是否必填：否 - 容器名称（前缀匹配）<br/>【告警字段过滤】（精确匹配，支持多值）<br/>Status - int - 是否必填：否 - 处理状态<br/>Level - int - 是否必填：否 - 威胁等级<br/>AlertCategory - string - 是否必填：否 - 告警大类<br/>AlertSubType - string - 是否必填：否 - 告警子类型<br/>AttackStage - string - 是否必填：否 - 攻击阶段<br/>DetectMode - string - 是否必填：否 - 检测模式<br/>AlertSource - string - 是否必填：否 - 告警来源（HOST/CONTAINER）<br/>AlertId - string - 是否必填：否 - 告警ID<br/>InstanceId - string - 是否必填：否 - 实例ID（精确匹配）<br/>ContainerId - string - 是否必填：否 - 容器ID（精确匹配）<br/>ClusterId - string - 是否必填：否 - 集群ID（精确匹配）<br/>【时间范围】<br/>StartTime - string - 是否必填：否 - 开始时间，格式 2006-01-02 15:04:05（默认近180天）<br/>EndTime - string - 是否必填：否 - 结束时间，格式 2006-01-02 15:04:05（默认当前时间）</p>
        /// </summary>
        [JsonProperty("Filters")]
        public EDRFilter[] Filters{ get; set; }

        /// <summary>
        /// <p>限制条数,默认10,最大100</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>偏移量,默认0</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>排序方式: [ASC:升序|DESC:降序]</p>
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// <p>可选排序列: [LatestDetectTime]</p>
        /// </summary>
        [JsonProperty("By")]
        public string By{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "By", this.By);
        }
    }
}

