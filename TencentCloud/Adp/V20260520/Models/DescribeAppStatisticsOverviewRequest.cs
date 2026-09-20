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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAppStatisticsOverviewRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>应用类型。可选值：APP_TYPE_RAG（RAG）、APP_TYPE_WORKFLOW（Workflow）、APP_TYPE_CLAW（Claw）、APP_TYPE_MULTIAGENT（MultiAgent）；本期仅 APP_TYPE_RAG 生效，其余为预留值，传入将返回 InvalidParameter</p><table><tbody><tr><td>枚举项</td><td>枚举值</td><td>描述</td></tr><tr><td>APP_TYPE_UNSPECIFIED</td><td>0</td><td>未指定（无效值，请求勿传）</td></tr><tr><td>APP_TYPE_RAG</td><td>1</td><td>RAG（本期唯一支持）</td></tr><tr><td>APP_TYPE_WORKFLOW</td><td>2</td><td>Workflow（预留，暂不支持）</td></tr><tr><td>APP_TYPE_CLAW</td><td>3</td><td>Claw（预留，暂不支持）</td></tr><tr><td>APP_TYPE_MULTIAGENT</td><td>4</td><td>MultiAgent（预留，暂不支持）</td></tr></tbody></table>
        /// </summary>
        [JsonProperty("AppType")]
        public long? AppType{ get; set; }

        /// <summary>
        /// <p>查询时间范围（Unix 秒）</p>
        /// </summary>
        [JsonProperty("TimeRange")]
        public TimeRange TimeRange{ get; set; }

        /// <summary>
        /// <p>视图范围：应用视图（VIEW_TYPE_APP），scope_id 填应用 ID（uint64 雪花 ID 的十进制字符串）</p>
        /// </summary>
        [JsonProperty("ViewScope")]
        public ViewScope ViewScope{ get; set; }

        /// <summary>
        /// <p>空间 ID</p><p>参数格式：<p>空间 ID</p></p><p>默认值：default_space</p>
        /// </summary>
        [JsonProperty("SpaceId")]
        public string SpaceId{ get; set; }

        /// <summary>
        /// <p>应用 ID</p><p>参数格式：</p><p>应用 ID</p><p></p><p>参考值：2099767969573745984</p>
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// <p>扩展过滤。Filter 组合规则：多项 AND，同项 value_list OR。支持 Name：space_id（空间 ID）、channel_type（调用方式/渠道类型，取值参考 trpc.adp.common.v2.ChannelType 枚举名）；channel_type 不传时按全部渠道聚合</p>
        /// </summary>
        [JsonProperty("FilterList")]
        public Filter[] FilterList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppType", this.AppType);
            this.SetParamObj(map, prefix + "TimeRange.", this.TimeRange);
            this.SetParamObj(map, prefix + "ViewScope.", this.ViewScope);
            this.SetParamSimple(map, prefix + "SpaceId", this.SpaceId);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamArrayObj(map, prefix + "FilterList.", this.FilterList);
        }
    }
}

