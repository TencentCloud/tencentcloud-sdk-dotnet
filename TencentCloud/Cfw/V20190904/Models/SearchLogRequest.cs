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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SearchLogRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>要检索分析的日志的起始时间，Unix时间戳（毫秒）</p>
        /// </summary>
        [JsonProperty("From")]
        public long? From{ get; set; }

        /// <summary>
        /// <p>要检索分析的日志的结束时间，Unix时间戳（毫秒）</p>
        /// </summary>
        [JsonProperty("To")]
        public long? To{ get; set; }

        /// <summary>
        /// <p>检索分析语句，最大长度为12KB<br>语句由 <a href="https://cloud.tencent.com/document/product/614/47044" target="_blank">[检索条件]</a> | <a href="https://cloud.tencent.com/document/product/614/44061" target="_blank">[SQL语句]</a>构成，无需对日志进行统计分析时，可省略其中的管道符<code> | </code>及SQL语句<br>使用*或空字符串可查询所有日志</p>
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// <p>检索语法规则，默认值为0，推荐使用1 。</p><ul><li>0：Lucene语法</li><li>1：CQL语法（日志服务专用检索语法，控制台默认也使用该语法规则）。</li></ul><p>详细说明参见<a href="https://cloud.tencent.com/document/product/614/47044#RetrievesConditionalRules" target="_blank">检索条件语法规则</a></p>
        /// </summary>
        [JsonProperty("SyntaxRule")]
        public ulong? SyntaxRule{ get; set; }

        /// <summary>
        /// <ul><li>要检索分析的日志主题ID，仅能指定一个日志主题。</li><li>如需同时检索多个日志主题，请使用Topics参数。</li><li>TopicId 和 Topics 不能同时使用，在一次请求中有且只能选择一个。<br>各日志主题ID如下<br>访问控制-互联网边界 cfw_rule_acl<br>访问控制-NAT边界 cfw_rule_nat_acl<br>访问控制-VPC边界 cfw_rule_vpc_acl<br>访问控制-DNS开关 cfw_rule_dns_acl<br>入侵防御 cfw_rule_threatinfo<br>全流量检测与响应日志-流量分析 cfw_netflow_nta<br>全流量检测与响应日志-流量告警 cfw_rule_ndr_threatinfo<br>零信任运维-数据库登录 cfw_operate_db<br>零信任运维-服务器访问 operate_remote_om<br>零信任运维-Web服务访问 operate_web_access<br>零信任运维-行为审计 remoteom_commands<br>流量日志-互联网边界 cfw_netflow_border<br>流量日志-NAT边界 cfw_netflow_nat<br>流量日志-VPC边界 cfw_netflow_vpc<br>流量日志-DNS开关 cfw_netflow_dns<br>流量日志-内网流量 cfw_netflow_fl<br>操作日志 operate_log_all</li></ul>
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// <ul><li>要检索分析的日志主题列表，最大支持50个日志主题。</li><li>检索单个日志主题时请使用TopicId。</li><li>TopicId 和 Topics 不能同时使用，在一次请求中有且只能选择一个。</li></ul>
        /// </summary>
        [JsonProperty("Topics")]
        public MultiTopicSearchInformation[] Topics{ get; set; }

        /// <summary>
        /// <p>原始日志是否按时间排序返回；可选值：asc(升序)、desc(降序)，默认为 desc<br>注意：</p><ul><li>仅当检索分析语句(Query)不包含SQL时有效</li><li>SQL结果排序方式参考<a href="https://cloud.tencent.com/document/product/614/58978" target="_blank">SQL ORDER BY语法</a></li></ul>
        /// </summary>
        [JsonProperty("Sort")]
        public string Sort{ get; set; }

        /// <summary>
        /// <p>表示单次查询返回的原始日志条数，默认为100，最大值为1000。<br>注意：</p><ul><li>仅当检索分析语句(Query)不包含SQL时有效</li><li>SQL结果条数指定方式参考<a href="https://cloud.tencent.com/document/product/614/58977" target="_blank">SQL LIMIT语法</a></li></ul><p>可通过两种方式获取后续更多日志：</p><ul><li>Context:透传上次接口返回的Context值，获取后续更多日志，总计最多可获取1万条原始日志</li><li>Offset:偏移量，表示从第几行开始返回原始日志，无日志条数限制</li></ul>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>查询原始日志的偏移量，表示从第几行开始返回原始日志，默认为0。<br>注意：</p><ul><li>仅当检索分析语句(Query)不包含SQL时有效</li><li>不能与Context参数同时使用</li><li>仅适用于单日志主题检索</li></ul>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <p>透传上次接口返回的Context值，可获取后续更多日志，总计最多可获取1万条原始日志，过期时间1小时。<br>注意：</p><ul><li>透传该参数时，请勿修改除该参数外的其它参数</li><li>仅适用于单日志主题检索，检索多个日志主题时，请使用Topics中的Context</li><li>仅当检索分析语句(Query)不包含SQL时有效，SQL获取后续结果参考<a href="https://cloud.tencent.com/document/product/614/58977" target="_blank">SQL LIMIT语法</a></li></ul>
        /// </summary>
        [JsonProperty("Context")]
        public string Context{ get; set; }

        /// <summary>
        /// <p>执行统计分析（Query中包含SQL）时，是否对原始日志先进行采样，再进行统计分析。<br>0：自动采样;<br>0～1：按指定采样率采样，例如0.02;<br>1：不采样，即精确分析<br>默认值为1</p>
        /// </summary>
        [JsonProperty("SamplingRate")]
        public float? SamplingRate{ get; set; }

        /// <summary>
        /// <p>为true代表使用新的检索结果返回方式，输出参数AnalysisRecords和Columns有效<br>为false时代表使用老的检索结果返回方式, 输出AnalysisResults和ColNames有效<br>两种返回方式在编码格式上有少量区别，建议使用true</p>
        /// </summary>
        [JsonProperty("UseNewAnalysis")]
        public bool? UseNewAnalysis{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "From", this.From);
            this.SetParamSimple(map, prefix + "To", this.To);
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamSimple(map, prefix + "SyntaxRule", this.SyntaxRule);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamArrayObj(map, prefix + "Topics.", this.Topics);
            this.SetParamSimple(map, prefix + "Sort", this.Sort);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Context", this.Context);
            this.SetParamSimple(map, prefix + "SamplingRate", this.SamplingRate);
            this.SetParamSimple(map, prefix + "UseNewAnalysis", this.UseNewAnalysis);
        }
    }
}

