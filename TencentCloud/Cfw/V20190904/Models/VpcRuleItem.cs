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

    public class VpcRuleItem : AbstractModel
    {
        
        /// <summary>
        /// <p>规则描述。新增和修改按请求中的字符串保存。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>访问目的内容，由 DestType 决定格式和校验。net/ip 接受合法 IP 或 CIDR 的逗号分隔列表，最多 10 项；domain 接受合法域名的逗号分隔列表或单独的 *，最多 10 项，通配域名最多 5 级，段内通配域名还要求引擎支持对应能力；template 接受当前租户的地址模板标识并归一化为模板 UUID，IP 地址模板必须与 IpVersion 一致，域名地址模板按域名目的校验；dnsparse 接受单个非 IP 域名或当前租户的域名模板，可使用符合级数限制的 *. 前缀泛域名，但不接受单独的 * 或段内通配；domainiptwoverify 接受单个非 IP 精确域名或不含任何通配符的当前租户域名模板；instance 和 tag 必须在当前租户存在，其中 instance 必须具有 IpVersion 对应的私网地址；group 接受资源组标识。location 会校验地域代码，但解析出的地域代码未写入 VPC 规则且目的内容保存为空；vendor 会校验厂商名称并将其归一化代码写入目的内容。归一化后的目的内容超过 1023 字节时请求失败。</p>
        /// </summary>
        [JsonProperty("DestContent")]
        public string DestContent{ get; set; }

        /// <summary>
        /// <p>访问目的类型，不区分大小写。VPC 规则可用 net（ip 为同义值）、domain、template、dnsparse、domainiptwoverify、instance、tag、group、location 或 vendor；url 虽可被通用类型映射识别，但 VPC 出向内容解析不支持。地址模板、dnsparse、domainiptwoverify、严格模式域名模板和段内通配域名分别要求当前 VPC 防火墙引擎支持对应能力，否则返回 UnsupportedOperation。类型及地址模板查询到的实际类型共同决定 DestContent 和 Protocol 的校验。</p>
        /// </summary>
        [JsonProperty("DestType")]
        public string DestType{ get; set; }

        /// <summary>
        /// <p>规则生效的 VPC 边范围，不区分大小写。ALL 表示全部 VPC 间，cfws- 前缀表示指定 VPC 边；其它格式返回参数错误。ALL 还要求相关 VPC 防火墙引擎支持全局规则，否则返回 UnsupportedOperation。</p>
        /// </summary>
        [JsonProperty("EdgeId")]
        public string EdgeId{ get; set; }

        /// <summary>
        /// <p>规则状态。字符串 true 表示启用，false 表示禁用，大小写不敏感；省略或传空字符串时使用租户通知配置中的默认规则状态，该配置没有可用值时默认启用；其它字符串返回参数错误。</p>
        /// </summary>
        [JsonProperty("Enable")]
        public string Enable{ get; set; }

        /// <summary>
        /// <p>规则在相同 IpVersion 的中间分区内的顺序。请求整数先转换为 uint32，0 归一化为 1，负整数及超出 uint32 范围的整数按该转换结果处理；写入时，顺序为 1 或不大于当前最大顺序的规则在该位置插入并将现有规则后移，通常大于当前最大顺序的值归一化为末尾。例外是 AddVpcAcRule 未使用精确值 insert_rule 且首条规则解析后的顺序为 1 时，本批每条规则都保留其解析后顺序并按该值移动现有规则，因此后续规则即使大于当前最大顺序也不会归一化为末尾。</p>
        /// </summary>
        [JsonProperty("OrderIndex")]
        public long? OrderIndex{ get; set; }

        /// <summary>
        /// <p>访问控制策略的端口。除 ICMP 和 ICMPV6 外，该字段按逗号拆分；每项可以是正整数单端口，或以斜杠分隔且起点不大于终点的两个整数，-1/-1 表示全部端口。ICMP 和 ICMPV6 忽略请求值并保存为空字符串；其它协议的空值或非法格式返回参数错误。FTP 只接受正整数单端口，不接受逗号组合或斜杠区间。</p>
        /// </summary>
        [JsonProperty("Port")]
        public string Port{ get; set; }

        /// <summary>
        /// <p>协议名称，不区分大小写并归一化。IP、instance、tag、group、location、vendor 及 IP 地址模板目的支持 TCP、UDP、ICMP、ICMPV6、ANY 和 FTP，其中 FTP 只接受单端口；domain 及域名地址模板目的支持 ANY、HTTP、HTTPS、HTTP/HTTPS、TLS/SSL、SMTP、SMTPS、SMTP/SMTPS 和 DNS，不支持 FTP，domain、tls、ssl 归一化为 TLS/SSL；dnsparse 和 domainiptwoverify 仅支持 TCP 或 UDP。template 按查询到的实际模板类型应用上述限制；填写 ParamTemplateId 时，组内每个协议端口项还会应用相同的目的类型限制。</p>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// <p>流量通过云防火墙时的处理方式，不区分大小写。accept 表示放行，drop 表示拒绝，log 表示观察；isolateinaccept 和 isolateoutaccept 归一化为放行，isolateindrop 和 isolateoutdrop 归一化为拒绝；其它值返回参数错误。</p>
        /// </summary>
        [JsonProperty("RuleAction")]
        public string RuleAction{ get; set; }

        /// <summary>
        /// <p>访问源内容，由 SourceType 决定格式和校验。net/ip 接受合法 IP 或 CIDR 的逗号分隔列表，最多 10 项；template 接受当前租户的地址模板标识并归一化为模板 UUID，只允许与 IpVersion 一致的 IP 地址模板，域名地址模板不能作为访问源；instance 和 tag 必须在当前租户存在，其中 instance 必须具有 IpVersion 对应的私网地址；group 接受资源组标识。</p>
        /// </summary>
        [JsonProperty("SourceContent")]
        public string SourceContent{ get; set; }

        /// <summary>
        /// <p>访问源类型，不区分大小写。VPC 规则可用 net（ip 为同义值）、template、instance、tag 或 group；url、location 和 vendor 虽可被通用类型映射识别，但 VPC 出向源内容解析不支持。使用 template 要求当前 VPC 防火墙引擎支持地址模板能力。类型及模板查询到的实际类型共同决定 SourceContent 的校验。</p>
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// <p>规则关联的 beta 任务详情。请求中的该字段不参与新增或修改规则构造，主要用于查询返回。</p>
        /// </summary>
        [JsonProperty("BetaList")]
        public BetaInfoByACL[] BetaList{ get; set; }

        /// <summary>
        /// <p>规则创建时间。请求中的该字段不参与新增或修改规则构造，主要用于查询返回。</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>规则删除标记，1 表示已删除，0 表示未删除。请求中的该字段不参与新增或修改规则构造，主要用于查询返回。</p>
        /// </summary>
        [JsonProperty("Deleted")]
        public long? Deleted{ get; set; }

        /// <summary>
        /// <p>查询结果中对目的实际类型的补充提示，例如 template 可区分 IP 地址模板和域名地址模板。新增和修改处理程序不读取请求中的该字段；实际目的类型由 DestType、DestContent 和模板查询结果确定。</p>
        /// </summary>
        [JsonProperty("DestValueType")]
        public string DestValueType{ get; set; }

        /// <summary>
        /// <p>规则命中次数。请求中的该字段不参与新增或修改规则构造，主要用于查询返回。</p>
        /// </summary>
        [JsonProperty("DetectedTimes")]
        public long? DetectedTimes{ get; set; }

        /// <summary>
        /// <p>EdgeId 对应的 VPC 边名称。请求中的该字段不参与新增或修改规则构造，主要用于查询返回和操作记录展示。</p>
        /// </summary>
        [JsonProperty("EdgeName")]
        public string EdgeName{ get; set; }

        /// <summary>
        /// <p>规则生效的防火墙组或 CCN 范围，格式比较不区分大小写。ALL 归一化为大写 ALL；cfwg- 前缀和 ccn- 前缀的值保留请求原文；省略、空字符串或其它格式归一化为 ALL，处理程序不因格式无效而返回错误。</p>
        /// </summary>
        [JsonProperty("FwGroupId")]
        public string FwGroupId{ get; set; }

        /// <summary>
        /// <p>防火墙组或 CCN 名称。请求中的该字段不参与新增或修改规则构造，主要用于查询返回和操作记录展示。</p>
        /// </summary>
        [JsonProperty("FwGroupName")]
        public string FwGroupName{ get; set; }

        /// <summary>
        /// <p>内部规则标识。AddVpcAcRule 的精确 batch_import_cover 分支会采用正整数 InternalUuid 替换自动生成的内部标识；其它新增分支和 ModifyVpcAcRule 不读取请求中的该字段。</p>
        /// </summary>
        [JsonProperty("InternalUuid")]
        public long? InternalUuid{ get; set; }

        /// <summary>
        /// <p>查询结果中的规则有效性标记，0 表示有效，1 表示无效。请求中的该字段不参与新增或修改规则构造。</p>
        /// </summary>
        [JsonProperty("Invalid")]
        public long? Invalid{ get; set; }

        /// <summary>
        /// <p>IP 版本，0 表示 IPv4，1 表示 IPv6。省略或传入 0、1 以外的整数时按 IPv4 处理；instance 必须具有对应版本的私网地址，IP 地址模板必须与解析后的版本一致。处理程序不使用该字段校验直接填写的 net IP/CIDR 版本。</p>
        /// </summary>
        [JsonProperty("IpVersion")]
        public long? IpVersion{ get; set; }

        /// <summary>
        /// <p>端口协议组 ID。省略或传空字符串时直接使用 Protocol 和 Port；非空时查询当前租户的端口协议组并用组内协议端口项执行目的类型和协议类别校验，模板查询失败时请求失败。无论是否填写该字段，请求中的 Protocol 和非 ICMP/ICMPV6 Port 都会先按普通规则解析，格式无效时请求失败。</p>
        /// </summary>
        [JsonProperty("ParamTemplateId")]
        public string ParamTemplateId{ get; set; }

        /// <summary>
        /// <p>端口协议组名称。请求中的该字段不参与新增或修改规则构造，主要用于查询返回。</p>
        /// </summary>
        [JsonProperty("ParamTemplateName")]
        public string ParamTemplateName{ get; set; }

        /// <summary>
        /// <p>规则分区展示值，1 表示最前分区，2 表示中间分区，3 表示最后分区。新增和修改处理程序不读取请求中的该字段，写入时固定为中间分区；ModifyVpcAcRule 只能定位并替换中间分区中的现有规则。</p>
        /// </summary>
        [JsonProperty("RulePartition")]
        public long? RulePartition{ get; set; }

        /// <summary>
        /// <p>访问源名称。请求中的该字段不参与新增或修改规则构造，主要用于查询返回和操作记录展示。</p>
        /// </summary>
        [JsonProperty("SourceName")]
        public string SourceName{ get; set; }

        /// <summary>
        /// <p>访问目的名称。请求中的该字段不参与新增或修改规则构造，主要用于查询返回和操作记录展示。</p>
        /// </summary>
        [JsonProperty("TargetName")]
        public string TargetName{ get; set; }

        /// <summary>
        /// <p>规则最近更新时间。请求中的该字段不参与新增或修改规则构造，主要用于查询返回。</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>规则数据库 ID。ModifyVpcAcRule 必须传当前租户中间分区内既有规则的正整数 Uuid；处理程序按该 ID 删除原记录并以同一 ID 插入替换后的规则。AddVpcAcRule 的普通新增、insert_rule 和 batch_import 分支忽略该字段；精确 batch_import_cover 分支会采用正整数 Uuid 作为新记录 ID，非正数值仍由数据库生成 ID。</p>
        /// </summary>
        [JsonProperty("Uuid")]
        public long? Uuid{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "DestContent", this.DestContent);
            this.SetParamSimple(map, prefix + "DestType", this.DestType);
            this.SetParamSimple(map, prefix + "EdgeId", this.EdgeId);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "OrderIndex", this.OrderIndex);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "RuleAction", this.RuleAction);
            this.SetParamSimple(map, prefix + "SourceContent", this.SourceContent);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamArrayObj(map, prefix + "BetaList.", this.BetaList);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Deleted", this.Deleted);
            this.SetParamSimple(map, prefix + "DestValueType", this.DestValueType);
            this.SetParamSimple(map, prefix + "DetectedTimes", this.DetectedTimes);
            this.SetParamSimple(map, prefix + "EdgeName", this.EdgeName);
            this.SetParamSimple(map, prefix + "FwGroupId", this.FwGroupId);
            this.SetParamSimple(map, prefix + "FwGroupName", this.FwGroupName);
            this.SetParamSimple(map, prefix + "InternalUuid", this.InternalUuid);
            this.SetParamSimple(map, prefix + "Invalid", this.Invalid);
            this.SetParamSimple(map, prefix + "IpVersion", this.IpVersion);
            this.SetParamSimple(map, prefix + "ParamTemplateId", this.ParamTemplateId);
            this.SetParamSimple(map, prefix + "ParamTemplateName", this.ParamTemplateName);
            this.SetParamSimple(map, prefix + "RulePartition", this.RulePartition);
            this.SetParamSimple(map, prefix + "SourceName", this.SourceName);
            this.SetParamSimple(map, prefix + "TargetName", this.TargetName);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
        }
    }
}

