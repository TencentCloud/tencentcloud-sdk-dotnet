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

namespace TencentCloud.Cfg.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ActionFieldConfigDetail : AbstractModel
    {
        
        /// <summary>
        /// 组件类型
        /// 可选项如下：
        /// input  文本框
        /// textarea  多行文本框
        /// number  数值输入框
        /// select   选择器
        /// cascader  级联选择器
        /// radio  单选
        /// time   时间选择
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 组件label
        /// </summary>
        [JsonProperty("Lable")]
        public string Lable{ get; set; }

        /// <summary>
        /// 组件唯一标识， 传回后端时的key
        /// </summary>
        [JsonProperty("Field")]
        public string Field{ get; set; }

        /// <summary>
        /// 默认值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DefaultValue")]
        public string DefaultValue{ get; set; }

        /// <summary>
        /// 支持配置项如下,可根据需要选择配置项，不需要配置是设置空{}：
        /// 
        /// {
        /// 
        ///   placeholder: string (占位符)
        /// 
        ///   tooltip: string (提示信息)
        /// 
        ///   reg: RegExp (对输入内容格式进行正则校验的规则)
        /// 
        ///   max: number (对于输入框，限制最大输入字符数，对于数值输入框，设置上限)
        /// 
        ///   min: number (对于数值输入框，设置下限)
        /// 
        ///   step: number (设置数值输入框的步长，默认为1)
        /// 
        ///   format: string (时间选择的格式，如YYYY-MM-DD表示年月日, YYYY-MM-DD HH:mm:ss 表示时分秒)
        /// 
        ///   separator:  string[] (多行输入框的分隔符，不传或者为空时表示不分隔，直接返回用户输入的文本字符串)
        /// 
        ///   multiple: boolean (是否多选,对选择器和级联选择器有效)
        /// 
        ///   options:  选择器的选项【支持以下两种形式】
        /// 
        /// 直接给定选项数组  { value: string; label: string }[]
        /// 通过调接口获取选项                                                                                                                                       { api: string(接口地址),                                                                                                                                       params: string[] (接口参数,对应于参数配置的field，前端根据field对应的所有组件的输入值作为参数查询数据， 为空时在组件加载时直接请求数据)                                                                                                    }
        /// }
        /// </summary>
        [JsonProperty("Config")]
        public string Config{ get; set; }

        /// <summary>
        /// 是否必填 (0 -- 否   1-- 是)
        /// </summary>
        [JsonProperty("Required")]
        public ulong? Required{ get; set; }

        /// <summary>
        /// compute配置依赖的其他field满足的条件时通过校验（如：三个表单项中必须至少有一个填写了）
        /// 
        /// [fieldName,
        /// 
        /// { config:  此项保留，等待后面具体场景细化  }
        /// 
        /// ]
        /// </summary>
        [JsonProperty("Validate")]
        public string Validate{ get; set; }

        /// <summary>
        /// 是否可见
        /// </summary>
        [JsonProperty("Visible")]
        public string Visible{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Lable", this.Lable);
            this.SetParamSimple(map, prefix + "Field", this.Field);
            this.SetParamSimple(map, prefix + "DefaultValue", this.DefaultValue);
            this.SetParamSimple(map, prefix + "Config", this.Config);
            this.SetParamSimple(map, prefix + "Required", this.Required);
            this.SetParamSimple(map, prefix + "Validate", this.Validate);
            this.SetParamSimple(map, prefix + "Visible", this.Visible);
        }
    }
}

