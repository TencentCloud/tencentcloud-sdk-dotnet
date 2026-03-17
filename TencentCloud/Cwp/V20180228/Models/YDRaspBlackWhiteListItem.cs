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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class YDRaspBlackWhiteListItem : AbstractModel
    {
        
        /// <summary>
        /// 规则ID
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 逻辑运算符，0: 下面5个有效的正则逻辑与 1: 逻辑或
        /// </summary>
        [JsonProperty("LogicalSymbol")]
        public ulong? LogicalSymbol{ get; set; }

        /// <summary>
        /// 类名正则表达式，为空则不匹配
        /// </summary>
        [JsonProperty("ClassNameRegexp")]
        public string ClassNameRegexp{ get; set; }

        /// <summary>
        /// 父类名正则表达式，为空则不匹配
        /// </summary>
        [JsonProperty("SuperClassNameRegexp")]
        public string SuperClassNameRegexp{ get; set; }

        /// <summary>
        /// 继承的接口正则表达式，为空则不匹配
        /// </summary>
        [JsonProperty("InterfacesRegexp")]
        public string InterfacesRegexp{ get; set; }

        /// <summary>
        /// 注释正则表达式，为空则不匹配
        /// </summary>
        [JsonProperty("AnnotationsRegexp")]
        public string AnnotationsRegexp{ get; set; }

        /// <summary>
        /// 所属的类加载器正则表达式，为空则不匹配
        /// </summary>
        [JsonProperty("LoaderClassNameRegexp")]
        public string LoaderClassNameRegexp{ get; set; }

        /// <summary>
        /// 白名单类型，rasp:漏洞防御,memshell_scan:内存马扫描, memshell_inject:内存马注入
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// 状态 (0: 有效 1: 删除，2：无效（启用开关关闭）)
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// 内存马扫描使用，处理历史事件， 0:不处理 1:处理
        /// </summary>
        [JsonProperty("HandleHistory")]
        public ulong? HandleHistory{ get; set; }

        /// <summary>
        /// rasp和内存马注入使用，匹配内容，POC，可以是正则表达式（MatchMode=5），也可以是字符串
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// rasp和内存马注入使用，攻击来源ip,不设置就是全部来源，可以多个，可以有ip段，例如：192.168.57.1/24;172.17.0.1
        /// </summary>
        [JsonProperty("IP")]
        public string IP{ get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// rasp和内存马注入使用，加白方式，0：恶意特征加白，1：请求URL加白
        /// </summary>
        [JsonProperty("FilterType")]
        public long? FilterType{ get; set; }

        /// <summary>
        /// rasp和内存马注入使用，攻击类型，vul.rasp_attacktype_mapping attack_type_id字段
        /// </summary>
        [JsonProperty("AttackType")]
        public long? AttackType{ get; set; }

        /// <summary>
        /// rasp和内存马注入使用，匹配模式，0:完全匹配,1：前缀匹配，2：后缀匹配，4：任意匹配，5：部分匹配，6：正则匹配
        /// </summary>
        [JsonProperty("MatchMode")]
        public long? MatchMode{ get; set; }

        /// <summary>
        /// 生效资产类型，0: 主机不生效 1: 主机生效
        /// </summary>
        [JsonProperty("CWPEffective")]
        public long? CWPEffective{ get; set; }

        /// <summary>
        /// 0: 一组quuid 1: 所有主机授权的机器
        /// </summary>
        [JsonProperty("CWPScope")]
        public long? CWPScope{ get; set; }

        /// <summary>
        /// 指定生效主机机器
        /// </summary>
        [JsonProperty("CWPQuuids")]
        public string[] CWPQuuids{ get; set; }

        /// <summary>
        /// 生效资产类型，0: 容器不生效 1: 容器生效
        /// </summary>
        [JsonProperty("TCSSEffective")]
        public long? TCSSEffective{ get; set; }

        /// <summary>
        /// 0: 一组quuid 1: 所有容器授权的node
        /// </summary>
        [JsonProperty("TCSSScope")]
        public long? TCSSScope{ get; set; }

        /// <summary>
        /// 指定生效容器节点
        /// </summary>
        [JsonProperty("TCSSQuuids")]
        public string[] TCSSQuuids{ get; set; }

        /// <summary>
        /// 生效资产类型，0: 超级节点不生效 1: 超级节点生效
        /// </summary>
        [JsonProperty("EksEffective")]
        public long? EksEffective{ get; set; }

        /// <summary>
        /// 0: 一组quuid 1: 所有容器授权的超级节点
        /// </summary>
        [JsonProperty("EksScope")]
        public long? EksScope{ get; set; }

        /// <summary>
        /// 指定生效容器超级节点
        /// </summary>
        [JsonProperty("EksNodeUniqueID")]
        public string[] EksNodeUniqueID{ get; set; }

        /// <summary>
        /// 应用资产，全局则：全部主机，否则是选择主机服务器的数量
        /// </summary>
        [JsonProperty("CWPMachinesNums")]
        public string CWPMachinesNums{ get; set; }

        /// <summary>
        /// 应用资产，全局则：全部容器主机节点，否则是选择容器主机节点的数量
        /// </summary>
        [JsonProperty("TCSSMachinesNums")]
        public string TCSSMachinesNums{ get; set; }

        /// <summary>
        /// 应用资产，全局则：全部超级节点，否则是选择超级节点的数量
        /// </summary>
        [JsonProperty("EksMachinesNums")]
        public string EksMachinesNums{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "LogicalSymbol", this.LogicalSymbol);
            this.SetParamSimple(map, prefix + "ClassNameRegexp", this.ClassNameRegexp);
            this.SetParamSimple(map, prefix + "SuperClassNameRegexp", this.SuperClassNameRegexp);
            this.SetParamSimple(map, prefix + "InterfacesRegexp", this.InterfacesRegexp);
            this.SetParamSimple(map, prefix + "AnnotationsRegexp", this.AnnotationsRegexp);
            this.SetParamSimple(map, prefix + "LoaderClassNameRegexp", this.LoaderClassNameRegexp);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "HandleHistory", this.HandleHistory);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "IP", this.IP);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "FilterType", this.FilterType);
            this.SetParamSimple(map, prefix + "AttackType", this.AttackType);
            this.SetParamSimple(map, prefix + "MatchMode", this.MatchMode);
            this.SetParamSimple(map, prefix + "CWPEffective", this.CWPEffective);
            this.SetParamSimple(map, prefix + "CWPScope", this.CWPScope);
            this.SetParamArraySimple(map, prefix + "CWPQuuids.", this.CWPQuuids);
            this.SetParamSimple(map, prefix + "TCSSEffective", this.TCSSEffective);
            this.SetParamSimple(map, prefix + "TCSSScope", this.TCSSScope);
            this.SetParamArraySimple(map, prefix + "TCSSQuuids.", this.TCSSQuuids);
            this.SetParamSimple(map, prefix + "EksEffective", this.EksEffective);
            this.SetParamSimple(map, prefix + "EksScope", this.EksScope);
            this.SetParamArraySimple(map, prefix + "EksNodeUniqueID.", this.EksNodeUniqueID);
            this.SetParamSimple(map, prefix + "CWPMachinesNums", this.CWPMachinesNums);
            this.SetParamSimple(map, prefix + "TCSSMachinesNums", this.TCSSMachinesNums);
            this.SetParamSimple(map, prefix + "EksMachinesNums", this.EksMachinesNums);
        }
    }
}

