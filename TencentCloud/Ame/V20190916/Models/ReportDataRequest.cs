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

namespace TencentCloud.Ame.V20190916.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReportDataRequest : AbstractModel
    {
        
        /// <summary>
        /// 上报数据
        /// 注:reportData为客户端压缩后的上报数据进行16进制转换的字符串数据
        /// 压缩说明：
        /// a) 上报的json格式字符串通过流的转换（ByteArrayInputStream, java.util.zip.GZIPOutputStream），获取到压缩后的字节数组。
        /// b) 将压缩后的字节数组转成16进制字符串。
        /// 
        /// reportData由两部分数据组成：
        /// 1）report_type（上报类型）
        /// 2）data（歌曲上报数据）
        /// 不同的report_type对应的data数据结构不一样。
        /// 
        /// 详细说明请参考文档reportdata.docx：
        /// https://github.com/ame-demo/doc
        /// </summary>
        [JsonProperty("ReportData")]
        public string ReportData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReportData", this.ReportData);
        }
    }
}

